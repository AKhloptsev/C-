using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Bubble_Sort
{
    public partial class Form1 : Form
    {
        private const int N = 100;  // number of elements
        private Random rm = new Random();
        private int[] mas = new int[N];
        private Rectangle[] rect = new Rectangle[N];
        private bool bFlag = false;

        public Form1()
        {
            InitializeComponent();
        }

        // array initialization recurring random numbers
        private void InitMas()
        {
            int n;
            for (int i = 0; i < N; i++)
            {
                do
                {
                    n = rm.Next(1, N + 1);
                    bFlag = false;
                    for (int j = 0; j < i; j++)
                    {
                        // if find the same numbers
                        if (n == mas[j])
                        {
                            bFlag = true;
                            break;
                        }
                    }
                } while (bFlag);
                mas[i] = n;
            }
            bFlag = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitMas();
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics gr = this.panel1.CreateGraphics();
            Size s = this.panel1.Size;
            //int factor = s.Width / N;
            //int fact = s.Height / N;
            for (int i = 0; i < N; i++)
            {
                rect[i] = new Rectangle(i * 5, s.Height - 3 * mas[i], 4, s.Height);
            }
            gr.FillRectangles(Brushes.DarkSeaGreen, rect);
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics gr = this.panel1.CreateGraphics();
            Size s = this.panel1.Size;
            // implementation of bubble sort
            do
            {
                bFlag = false;
                for (int i = 0; i < N - 1; i++)
                {
                    if (mas[i] > mas[i + 1])
                    {
                        int temp = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = temp;
                        gr.FillRectangle(Brushes.Red, rect[i]);
                        gr.FillRectangle(Brushes.Green, rect[i + 1]);
                        Thread.Sleep(50);
                        rect[i] = new Rectangle(i * 5, s.Height - 3 * mas[i], 4, s.Height);
                        rect[i + 1] = new Rectangle((i + 1) * 5, s.Height - 3 * mas[i + 1], 4, s.Height);
                        this.Refresh();
                        gr.FillRectangles(Brushes.DarkSeaGreen, rect);
                        bFlag = true;
                    }
                }
            } while (bFlag);
            // final round
            for (int i = 0; i < N; i++)
            {
                gr.FillRectangle(Brushes.Gold, rect[i]);
                Thread.Sleep(25);
            }
            gr.FillRectangles(Brushes.DarkSeaGreen, rect);
        }

        // if click Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}