using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Bubble_Sort
{
    public partial class MainForm : Form
    {
        private const int numberOfElements = 100;  // number of elements
        private Random rm = new Random();
        private int[] arr = new int[numberOfElements];
        private Rectangle[] rect = new Rectangle[numberOfElements];
        private bool bFlag = false;

        public MainForm()
        {
            InitializeComponent();
        }

        // array initialization recurring random numbers
        private void InitMas()
        {
            int n;
            for (int i = 0; i < numberOfElements; i++)
            {
                do
                {
                    n = rm.Next(1, numberOfElements + 1);
                    bFlag = false;
                    for (int j = 0; j < i; j++)
                    {
                        // if find the same numbers
                        if (n == arr[j])
                        {
                            bFlag = true;
                            break;
                        }
                    }
                } while (bFlag);
                arr[i] = n;
            }
            bFlag = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ShowArray()
        {
            Graphics gr = this.panel1.CreateGraphics();
            Size size = this.panel1.Size;
            int diffX = size.Width / numberOfElements;
            int diffY = size.Height / numberOfElements;
            for (int i = 0; i < numberOfElements; i++)
            {
                rect[i] = new Rectangle(i * diffX, size.Height - diffY * arr[i], diffX - 1, size.Height);
            }
            gr.FillRectangles(Brushes.DarkSeaGreen, rect);
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Refresh();
            InitMas();
            ShowArray();
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thrd = new Thread(new ThreadStart(this.ShowSort));
            thrd.Name = "ShowSort thread";
            thrd.Start();
        }

        private void ShowSort()
        {
            Graphics gr = this.panel1.CreateGraphics();
            Size size = this.panel1.Size;
            // implementation of bubble sort
            do
            {
                bFlag = false;
                for (int i = 0; i < numberOfElements - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        gr.FillRectangle(Brushes.Red, rect[i]);
                        gr.FillRectangle(Brushes.Green, rect[i + 1]);
                        Thread.Sleep(15);
                        int diffX = size.Width / numberOfElements;
                        int diffY = size.Height / numberOfElements;
                        rect[i] = new Rectangle(i * diffX, size.Height - diffY * arr[i], diffX - 1, size.Height);
                        rect[i + 1] = new Rectangle((i + 1) * diffX, size.Height - diffY * arr[i + 1], diffX - 1, size.Height);
                        this.Refresh();
                        gr.FillRectangles(Brushes.DarkSeaGreen, rect);
                        bFlag = true;
                    }
                }
            } while (bFlag);
            // final round
            for (int i = 0; i < numberOfElements; i++)
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

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            this.panel1.Refresh();
            ShowArray();
        }
    }
}