using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MetricsCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Program to convert inchs and centimeters
        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            str = textBoxInputString.Text;
            // regular expression
            string re = "(([0-9]+[.,]*[0-9]*)|([0-9]*[.,]*[0-9]+)) ((cm)|(in))";
            if (str != Regex.Match(str, re).ToString())
            {
                textBoxResult.Text = "Verification Error";
                errorProvider1.SetError(textBoxInputString, "Wrong format");
            }
            else
            {
                float number = 0;  // for
                string[] s = str.Split('.');
                // change '.' to ','
                str = s[0] + ',' + s[1];
                try
                {
                    number = Convert.ToSingle(str.Substring(0, str.Length - 3));    // number = str - 3 symbols (" cm|in")
                    if (number < 0f)
                    {
                        textBoxResult.Text = "Validation Error";
                        errorProvider1.SetError(textBoxInputString, "Negative number");
                    }
                }
                catch (Exception ex)
                {
                    textBoxResult.Text = ex.Message;
                }

                float result = 0f;
                bool bFlag = false;
                if (str.Substring(str.Length - 1, 1) == "m")    // if last symbol = 'm' ("cm")
                {
                    result = number / 2.54f;
                    bFlag = true;
                }
                // else ("in")
                else
                {
                    result = number * 2.54f;
                    bFlag = false;
                }
                if (bFlag)
                    textBoxResult.Text = result.ToString() + " in";
                else
                    textBoxResult.Text = result.ToString() + " cm";
            }
        }
    }
}