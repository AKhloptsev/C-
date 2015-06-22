using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyTelephoneBook
{
    public partial class Form1 : Form
    {
        private FileStream fileStream;    // write/open file

        Account<Blacklist> db = new Account<Blacklist>();   // db = database
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   // if click to exit then close form
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact addContact = new AddContact();
            addContact.ShowDialog();    // show a form of addition of contact
            if (addContact.DialogResult == DialogResult.OK)
            {
                db.Add(new Blacklist(addContact._Name, addContact._Surname, addContact._Number, addContact._Group, addContact._Photo, addContact._Blacklist));
                ShowData(); // refresh data after contact addition
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();     // show a form of open file
            if (dr == DialogResult.OK)
            {
                fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open);   // for opening file
                StreamReader sr = new StreamReader(fileStream);
                dataGrid.Rows.Clear();      // clear all data in datagrid and database
                db.Clear();
                try
                {
                    while (sr.ReadLine() != null)   // read all data in file
                    {
                        string name = sr.ReadLine();
                        string surname = sr.ReadLine();
                        int number = Convert.ToInt32(sr.ReadLine());
                        string photo = sr.ReadLine();
                        string group = sr.ReadLine();
                        bool blacklist = Convert.ToBoolean(sr.ReadLine());
                        db.Add(new Blacklist(name, surname, number, group, photo, blacklist));  // add contact to database
                    }
                    ShowData();     // refresh data
                }

                
                finally
                {
                    // close all streams
                    sr.Close();
                    fileStream.Close();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog(); // show a form of save file
            if (dr == DialogResult.OK)
            {
                fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create);     // for saving file
                StreamWriter sw = new StreamWriter(fileStream);
                for (int i = 0; i < db.Size; i++)      // write all database in file
                {
                    sw.WriteLine();
                    sw.WriteLine(db[i].Name);
                    sw.WriteLine(db[i].Surname);
                    sw.WriteLine(db[i].Number);
                    sw.WriteLine(db[i].Photo);
                    sw.WriteLine(db[i].Group);
                    sw.WriteLine(db[i]._Blacklist);
                }
                // close all streams
                sw.Close();
                fileStream.Close();
            }
        }

        // refresh dataGrid
        private void ShowData()
        {
            Bitmap img;
            string tmp;
            dataGrid.Rows.Clear();
            for (int i = 0; i < db.Size; i++)
            {
                dataGrid.Rows.Add();
                dataGrid.Rows[i].Cells[0].Value = db[i].Name + " " + db[i].Surname;
                dataGrid.Rows[i].Cells[1].Value = db[i].Number;
                tmp = db[i].Photo;
                img = new Bitmap("E:\\C#\\MyTelephoneBook\\MyTelephoneBook\\Resources\\" + tmp + ".jpg");
                dataGrid.Rows[i].Cells[2].Value = img;
                dataGrid.Rows[i].Cells[3].Value = db[i].Group;
                bool b = db[i]._Blacklist;
                if (b == true)
                    dataGrid.Rows[i].Cells[4].Value = true;
                else
                    dataGrid.Rows[i].Cells[4].Value = false;
            }
        }


        private void findToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FindForm ff = new FindForm();
            ff.ShowDialog();    // show find form dialog
            if (ff.DialogResult == DialogResult.OK)
            {
                bool success = false;
                int j = 0;
                bool result = Int32.TryParse(ff.Find, out j);   // if write numbers
                if (result == true)
                {
                    for (int i = 0; i < db.Size; i++)
                    {
                        if (db[i].Number == j)  // find contact with this phone number
                        {
                            string name = db[i].Name;
                            string surname = db[i].Surname;
                            int number = Convert.ToInt32(db[i].Number);
                            string group = db[i].Group;
                            success = true;
                            MessageBox.Show(this, name + " " + surname + " " + group + "\n" + number.ToString(), "Contact to such phone number is found", MessageBoxButtons.OK);
                        }
                    }
                }
                // else if write string find contact with this name or surname
                else if(!success)
                {
                    for (int i = 0; i < db.Size; i++)
                    {
                        if (db[i].Name == ff.Find)
                        {
                            string name = db[i].Name;
                            string surname = db[i].Surname;
                            int number = Convert.ToInt32(db[i].Number);
                            string group = db[i].Group;
                            success = true;
                            MessageBox.Show(this, name + " " + surname + " " + group + "\n" + number.ToString(), "Contact to such name is found", MessageBoxButtons.OK);
                        }
                    }
                }
                if (!success)
                {
                    for (int i = 0; i < db.Size; i++)
                    {
                        if (db[i].Surname == ff.Find)
                        {
                            string name = db[i].Name;
                            string surname = db[i].Surname;
                            int number = Convert.ToInt32(db[i].Number);
                            string group = db[i].Group;
                            success = true;
                            MessageBox.Show(this, name + " " + surname + " " + group + "\n" + number.ToString(), "Contact to such surname is found", MessageBoxButtons.OK);
                        }
                    }
                }
                // if dont find anything show dialog that we dont found contact with this string
                if(!success)
                    MessageBox.Show(this, "Unfortunately, such contact is not found", "Not found", MessageBoxButtons.OK);
            }
        }
    }
}
