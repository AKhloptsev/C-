using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyRegex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regEx = this.textBoxReg.Text;    // regEx = regular expression
            string text = this.textBoxText.Text;
            bool bFlag = false;
            if (regEx == "")
            {
                errorProvider1.SetError(textBoxReg, "Regular expression is absent");
                this.textBoxResult.Text = "Regular expression is absent";
                bFlag = true;
            }
            if (text == "")
            {
                errorProvider2.SetError(textBoxText, "Text is absent");
                this.textBoxResult.Text = "Text is absent";
                bFlag = true;
            }

            var rm = Regex.Match(text, regEx);

            if (!bFlag)     // if there are no problems with validation
            {
                if (rm.ToString() == text)
                    this.textBoxResult.Text = "Is regular expression";
                else
                    this.textBoxResult.Text = "Isn't regular expression";
            }
        }
    }
}