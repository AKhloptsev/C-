using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor
{
    public interface IMainForm
    {
        string FilePath { get; }

        string Content { get; set; }

        void SetSymbolCount(int count);

        event EventHandler FileOpenClick;

        event EventHandler FileSaveClick;

        event EventHandler ContentChanged;
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region implementation IMainForm

        public event EventHandler FileOpenClick;

        public event EventHandler FileSaveClick;

        public event EventHandler ContentChanged;

        public string FilePath
        {
            get { return TextBoxPath.Text; }
        }

        public string Content
        {
            get { return textBoxContent.Text; }
            set { textBoxContent.Text = value; }
        }

        public void SetSymbolCount(int count)
        {
            labelSymbolCount.Text = count.ToString();
        }

        #endregion implementation IMainForm

        #region event

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TextBoxPath.Text = openFileDialog.FileName;

                if (FileOpenClick != null)
                    FileOpenClick(sender, e);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null)
                FileSaveClick(sender, e);
        }

        private void textBoxContent_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null)
                ContentChanged(sender, e);
        }

        #endregion event

        private void numericFont_ValueChanged(object sender, EventArgs e)
        {
            textBoxContent.Font = new Font("Times New Roman", (float)numericFont.Value);
        }
    }
}