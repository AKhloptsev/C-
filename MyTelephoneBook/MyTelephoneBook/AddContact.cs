using System;
using System.Windows.Forms;

namespace MyTelephoneBook
{
    public partial class AddContact : Form
    {
        protected string name, surname, photo, group;
        protected int number;
        protected bool blacklist;

        #region Свойства

        public int _Number
        {
            get { return number; }
            set
            {
                if (number > 0)
                    number = value;
                else
                    errorProvider1.SetError(textBoxSurname, "Phone number should be positive");
            }
        }

        public bool _Blacklist
        {
            get { return blacklist; }
            set { blacklist = value; }
        }

        public string _Group
        {
            get { return group; }
            set { group = value; }
        }

        public string _Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public string _Surname
        {
            get { return surname; }
            set
            {
                if (value != "")
                    surname = value;
                else
                    errorProvider1.SetError(textBoxSurname, "Specify, please, a surname.");
            }
        }

        public string _Name
        {
            get { return name; }
            set
            {
                if (value != "")
                    name = value;
                else
                    errorProvider1.SetError(textBoxName, "Specify, please, a name.");
            }
        }

        #endregion Свойства

        public AddContact()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool bFlag = true;
            name = textBoxName.Text;
            if (name == "")
                errorProvider1.SetError(textBoxName, "Enter a name");
            surname = textBoxSurname.Text;
            if (name == "")
                errorProvider1.SetError(textBoxSurname, "Enter a surname");
            try
            {
                number = Convert.ToInt32(textBoxNumber.Text);
                if (number <= 0)
                {
                    throw new Exception("Phone number should be positive");
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxNumber, ex.Message);
                bFlag = false;
            }
            blacklist = checkBoxBlacklist.Checked;
            if (comboBoxPhoto.SelectedIndex != -1)
            {
                switch (comboBoxPhoto.SelectedIndex)
                {
                    case 0:
                        photo = "boy";
                        break;

                    case 1:
                        photo = "girl";
                        break;
                }
            }
            else
            {
                errorProvider1.SetError(comboBoxPhoto, "Choose a photo from the list");
                this.DialogResult = DialogResult.None;
                bFlag = false;
            }

            if (comboBoxGroup.SelectedIndex != -1)
            {
                switch (comboBoxGroup.SelectedIndex)
                {
                    case 0:
                        group = "Family";
                        break;

                    case 1:
                        group = "Friends";
                        break;

                    case 2:
                        group = "Study";
                        break;

                    case 3:
                        group = "Work";
                        break;
                }
            }
            else
            {
                errorProvider1.SetError(comboBoxGroup, "Choose a group from the list");
                this.DialogResult = DialogResult.None;
                bFlag = false;
            }
            if (bFlag)
                this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}