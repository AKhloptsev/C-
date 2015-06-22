using System;
using System.Windows.Forms;

namespace MyTelephoneBook
{
    public partial class FindForm : Form
    {
        private string find;

        public string Find
        {
            get { return find; }
            set
            {
                if (value != "")
                    find = value;
            }
        }

        public FindForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            find = textBoxFind.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}