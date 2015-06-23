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
            string inputString = "";
            inputString = textBoxInputString.Text;
            // re = regular expression
            string re = "(([0-9]+[.,]*[0-9]*)|([0-9]*[.,]*[0-9]+)) ((cm)|(in))";
            if (inputString != Regex.Match(inputString, re).ToString())
            {
                textBoxResult.Text = "Verification Error";
                errorProvider1.SetError(textBoxInputString, "Wrong format");
            }
            else
            {
                float number = 0;
                string[] substringArray = inputString.Split('.');
                // change '.' to ','
                inputString = substringArray[0] + ',' + substringArray[1];
                try
                {
                    number = Convert.ToSingle(inputString.Substring(0, inputString.Length - 3));    // number = str - 3 symbols (" cm|in")
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

                float result = 0f;      // Stores result of transfer
                bool bFlag = false;
                if (inputString.Substring(inputString.Length - 1, 1) == "m")    // if last symbol = 'm' ("cm")
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