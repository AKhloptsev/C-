using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace MyExplorer
{
    public partial class MainForm : Form
    {
        private List<string> historyOfAddress = new List<string>(); // список, который хранит историю посещённых адрессов
        private int currentAddressIndex = -1;    // индекс текущего адресса из списка

        public MainForm()
        {
            InitializeComponent();
            //_________________________________________________//
            int numberOfNodes = 0;
            try
            {
                // кидает исключение
                string[] logicalDrives = Environment.GetLogicalDrives();    // массив строк, хранящий названия логических дисков
                foreach (string logicalDrive in logicalDrives)
                {
                    TreeNode treeNode = new TreeNode(); // создаём новый узел для TreeView
                    treeNode.Name = logicalDrive;    // имя узла = имени логического диска
                    treeNode.Text = "Logical drive " + logicalDrive;      // текст, который отображается в treeView
                    treeView1.Nodes.Add(treeNode);    // добавляем текущий узел
                    // кидает исключение
                    string[] directories = Directory.GetDirectories(logicalDrive);  // массив строк, хранящий директории данного диска
                    foreach (string directory in directories)
                    {
                        TreeNode tn = new TreeNode();
                        tn.Name = directory;    // в имени должен хранится весь путь к файлу
                        tn.Text = directory.Substring(directory.LastIndexOf('\\') + 1);  // название папки (без полного пути)
                        treeView1.Nodes[numberOfNodes].Nodes.Add(tn);    // добавляем папку как подузел диска
                    }
                    numberOfNodes++;
                }
            }
            catch
            {
                //throw new Exception("Error in MainForm constructor");
                // пишет устройство не готово
            }
        }

        // метод, который вызывается при раскрытии (нажатии на +) в дереве каталогов
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            int numberOfNodes = 0;
            try
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    string[] directories = Directory.GetDirectories(node.Name);
                    foreach (var directory in directories)
                    {
                        TreeNode treeNode = new TreeNode();
                        treeNode.Name = directory;
                        treeNode.Text = directory.Substring(directory.LastIndexOf('\\') + 1); ;
                        e.Node.Nodes[numberOfNodes].Nodes.Add(treeNode);
                    }
                    numberOfNodes++;
                }
            }
            catch
            {
                throw new Exception("Error in treeView1_BeforeExpand method");
            }
        }

        // метод, который вызывается при выборе диска\папки
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // вызываем метод "Переход"
            try
            {
                historyOfAddress.Add(e.Node.Name);
                currentAddressIndex++;
                Transition(e.Node.Name);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private void Transition(string name)
        {
            int numberOfElements = 0;
            // проверяем можно ли включить кнопку "вперёд"
            if (currentAddressIndex + 1 == historyOfAddress.Count)     // если это последний добавленный узел
                toolStripButtonForward.Enabled = false;
            else
                toolStripButtonForward.Enabled = true;
            // проверяем можно ли включить кнопку "назад"
            if (currentAddressIndex - 1 == -1)      // если это первый добавленный узел
                toolStripButtonBack.Enabled = false;
            else
                toolStripButtonBack.Enabled = true;
            // очищаем ListView
            listView1.Items.Clear();
            toolStripTextBoxPath.Text = name;     // выводим путь
            //заполняем ListView
            // если выводим в таблице, то
            if (listView1.View == View.Details)
            {
                string[] directories = Directory.GetDirectories(name);   // массив директорий данного узла

                foreach (string directory in directories)   // перебираем каждую папку
                {
                    FileInfo fileInfo = new FileInfo(directory);
                    string _name = directory.Substring(directory.LastIndexOf('\\') + 1);
                    ListViewItem lvi = new ListViewItem(new string[] { _name, fileInfo.LastWriteTime.ToString(), "Папка", "" }, 0);
                    lvi.Name = directory;
                    listView1.Items.Add(lvi);
                }

                directories = Directory.GetFiles(name);  // массив файлов в данном узле
                foreach (string file in directories)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    string _name = file.Substring(file.LastIndexOf('\\') + 1);
                    long length = fileInfo.Length;
                    string size = "";
                    if (length < 1024)
                        size = length.ToString() + " байт";
                    else
                        size = (length / 1024).ToString() + " КБ";
                    ListViewItem lvi = new ListViewItem(new string[] { _name, fileInfo.LastWriteTime.ToString(), "Файл", size }, 1);
                    lvi.Name = file;
                    listView1.Items.Add(lvi);
                }
            }

            else
            {
                string[] directories = Directory.GetDirectories(name);   // массив директорий данного узла
                numberOfElements += directories.Length;
                foreach (string directory in directories)   // перебираем каждую папку
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = directory.Substring(directory.LastIndexOf('\\') + 1);
                    lvi.Name = directory;
                    lvi.ImageIndex = 0;
                    listView1.Items.Add(lvi);
                }

                directories = Directory.GetFiles(name);  // массив файлов в данном узле
                numberOfElements += directories.Length;
                foreach (string file in directories)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = file.Substring(file.LastIndexOf('\\') + 1);
                    lvi.Name = file;
                    lvi.ImageIndex = 1;
                    listView1.Items.Add(lvi);
                }
            }
            
            string logicalDisk = toolStripTextBoxPath.Text.Substring(0, 3);
            DriveInfo di = new DriveInfo(@logicalDisk);
            double Free = (di.AvailableFreeSpace / 1024) / 1024;
            textBoxStatus.Text = numberOfElements.ToString() + " elements " + logicalDisk + Free.ToString() + " Mb free";
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (currentAddressIndex + 1 != historyOfAddress.Count)
            {
                int count = historyOfAddress.Count;
                for (int i = count - 1; i > currentAddressIndex; i--)
                {
                    historyOfAddress.RemoveAt(i);
                }
            }

            if (listView1.SelectedItems[0].ImageIndex == 0)  // если два раза щёлкнули по папке
            {
                // т.е. если это папка, то вызываем метод "Переход"
                historyOfAddress.Add(listView1.SelectedItems[0].Name);
                currentAddressIndex++;
                Transition(listView1.SelectedItems[0].Name);
            }
            // если это исполняемый файл
            else
            {
                Process process = new Process();
                process.StartInfo.FileName = listView1.SelectedItems[0].Name;
                process.Start();
            }
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Items.Clear();
            string currentAddress = toolStripTextBoxPath.Text;

            string[] directories = Directory.GetDirectories(currentAddress);
            foreach (string directory in directories)
            {
                FileInfo fileInfo = new FileInfo(directory);
                string name = directory.Substring(directory.LastIndexOf('\\') + 1);
                ListViewItem lvi = new ListViewItem(new string[] { name, fileInfo.LastWriteTime.ToString(), "Папка", "" }, 0);
                lvi.Name = directory;
                listView1.Items.Add(lvi);
            }

            directories = Directory.GetFiles(currentAddress);  // массив файлов в данном узле
            foreach (string file in directories)
            {
                FileInfo fileInfo = new FileInfo(file);
                string _name = file.Substring(file.LastIndexOf('\\') + 1);
                long length = fileInfo.Length;
                string size = "";
                if (length < 1024)
                    size = length.ToString() + " байт";
                else
                    size = (length / 1024).ToString() + " КБ";
                ListViewItem lvi = new ListViewItem(new string[] { _name, fileInfo.LastWriteTime.ToString(), "Файл", size }, 1);
                lvi.Name = file;
                listView1.Items.Add(lvi);
            }
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            if (currentAddressIndex - 1 != -1)
            {
                currentAddressIndex--;
                string address = historyOfAddress[currentAddressIndex];
                Transition(address);
            }
        }

        private void toolStripButtonForward_Click(object sender, EventArgs e)
        {
            if (currentAddressIndex + 1 != historyOfAddress.Count)
            {
                currentAddressIndex++;
                string address = historyOfAddress[currentAddressIndex];
                Transition(address);
            }
        }

        // метод поиска файла
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            string path = toolStripTextBoxPath.Text;
            string searchPattern = toolStripTextBoxSearch.Text;
            listView1.View = View.Details;
            try
            {
                string[] foundFiles = Directory.GetFiles(path, searchPattern, SearchOption.AllDirectories);
                listView1.Items.Clear();
                string searchDirectory = path.Substring(path.LastIndexOf('\\') + 1);
                toolStripTextBoxPath.Text = "Поиск в " + searchDirectory;
                foreach (string file in foundFiles)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    string _name = file.Substring(file.LastIndexOf('\\') + 1);
                    long length = fileInfo.Length;
                    string size = "";
                    if (length < 1024)
                        size = length.ToString() + " байт";
                    else
                        size = (length / 1024).ToString() + " КБ";
                    ListViewItem lvi = new ListViewItem(new string[] { _name, fileInfo.LastWriteTime.ToString(), fileInfo.FullName.ToString(), size }, 1);
                    lvi.Name = file;
                    listView1.Items.Add(lvi);
                }
            }
            catch
            {
                throw new Exception("Error in find method");
            }
        }
    }
}