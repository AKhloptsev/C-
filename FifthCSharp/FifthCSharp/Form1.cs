using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifthCSharp
{
    public partial class Form1 : Form
    {
        const int N = 16;
        int[] numbersArray = new int[N];
        Button[] buttonsArray = new Button[N];
        Random rm = new Random();
        int nullButtonIndex;    // index of null button
        public Form1()
        {
            InitializeComponent();
        }

        // initialize the array with random numbers
        private void InitMas()
        {
            int randomNumber;
            bool bFlag;
            for (int i = 0; i < N; i++)
            {
                do
                {
                    randomNumber = rm.Next(0, N);
                    bFlag = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (randomNumber == numbersArray[j])
                        {
                            bFlag = true;
                            break;
                        }
                    }
                } while (bFlag);
                numbersArray[i] = randomNumber;
            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            object obj = (sender as Button).Tag;
            int clickIndex = (int)obj;
            int i = clickIndex / 4;
            int j = clickIndex % 4;
            int iNullButton = nullButtonIndex / 4;
            int jNullButton = nullButtonIndex % 4;
            // our click relatively nullBut
            //bottom
            if (iNullButton == i && jNullButton == j - 1)
            {
                numbersArray[nullButtonIndex] = numbersArray[clickIndex]; // swap the values in the array
                numbersArray[clickIndex] = 0;
                buttonsArray[clickIndex].Text = ""; // swap the text in the button array
                buttonsArray[nullButtonIndex].Text = numbersArray[nullButtonIndex].ToString();
                nullButtonIndex = clickIndex;   // new index of null button
            }
            //top
            if (iNullButton == i && jNullButton == j + 1)
            {
                numbersArray[nullButtonIndex] = numbersArray[clickIndex];
                numbersArray[clickIndex] = 0;
                buttonsArray[clickIndex].Text = "";
                buttonsArray[nullButtonIndex].Text = numbersArray[nullButtonIndex].ToString();
                nullButtonIndex = clickIndex;
            }
            //right
            if (iNullButton == i - 1 && jNullButton == j)
            {
                numbersArray[nullButtonIndex] = numbersArray[clickIndex];
                numbersArray[clickIndex] = 0;
                buttonsArray[clickIndex].Text = "";
                buttonsArray[nullButtonIndex].Text = numbersArray[nullButtonIndex].ToString();
                nullButtonIndex = clickIndex;
            }
            //left
            if (iNullButton == i + 1 && jNullButton == j)
            {
                numbersArray[nullButtonIndex] = numbersArray[clickIndex];
                numbersArray[clickIndex] = 0;
                buttonsArray[clickIndex].Text = "";
                buttonsArray[nullButtonIndex].Text = numbersArray[nullButtonIndex].ToString();
                nullButtonIndex = clickIndex;
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            InitMas();
            // create all buttons and add on screen
            for (int n = 0; n < N; n++)
            {
                int i = n % 4;
                int j = n / 4;
                buttonsArray[n] = new Button();
                buttonsArray[n].Size = new Size(75, 75);
                buttonsArray[n].Location = new Point(80 * i, 30 + 80 * j);
                buttonsArray[n].Tag = n;
                buttonsArray[n].Click += btn_click;
                if (numbersArray[n] == 0)
                {
                    buttonsArray[n].Text = "";
                    nullButtonIndex = n;
                }
                else
                    buttonsArray[n].Text = numbersArray[n].ToString();
                this.Controls.Add(buttonsArray[n]);
            }
        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, now this function does not work.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
