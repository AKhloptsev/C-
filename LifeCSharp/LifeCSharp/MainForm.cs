using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LifeCSharp
{
    public partial class MainForm : Form
    {
        private const int WIDTH = 39;
        private const int HEIGHT = 37;
        private const int squareSize = 10;
        private bool isOptimal = false;
        private int livePoints = -1;
        private int[,] world = new int[WIDTH, HEIGHT];
        private int[,] prevWorld = new int[WIDTH, HEIGHT];

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowGrid()
        {
            Graphics gr = this.panel1.CreateGraphics();
            // draw grid:
            // draw columns
            for (int i = 0; i < this.Size.Width; i += squareSize)
            {
                gr.DrawLine(Pens.Black, i, 0, i, this.Size.Height);
            }
            // draw rows
            for (int i = 0; i < this.Size.Height; i += squareSize)
            {
                gr.DrawLine(Pens.Black, 0, i, this.Size.Width, i);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ShowGrid();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics gr = this.panel1.CreateGraphics();
            int sx = (e.X - e.X % squareSize) / squareSize;
            int sy = (e.Y - e.Y % squareSize) / squareSize;
            world[sx, sy] = 1;
            for (int i = 0; i < WIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    if (world[i, j] == 1)
                        gr.FillRectangle(Brushes.Blue, new Rectangle(i * squareSize, j * squareSize, squareSize, squareSize));
                }
            }
        }


        private void Start()
        {
            Graphics gr = this.panel1.CreateGraphics();
            do
            {
                ShowGrid();
                copyWorld(world, prevWorld);
                nextGeneration(world, prevWorld);

                isOptimal = cmpWorld(world, prevWorld);
                livePoints = getLiveCount(world);

                if (isOptimal)
                {
                    MessageBox.Show("Optimal parameters are found!", "#", MessageBoxButtons.OK);
                }

                if (livePoints == 0)
                {
                    MessageBox.Show("All points died", "#", MessageBoxButtons.OK);
                }

                for (int i = 0; i < WIDTH; i++)
                {
                    for (int j = 0; j < HEIGHT; j++)
                    {
                        if (world[i, j] == 1)
                        {
                            gr.FillRectangle(Brushes.Blue, new Rectangle(i * squareSize, j * squareSize, squareSize, squareSize));
                        }
                        else
                        {
                            gr.FillRectangle(Brushes.White, new Rectangle(i * squareSize, j * squareSize, squareSize, squareSize));
                        }
                    }
                }
            } while (livePoints != 0 && !isOptimal);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thrd = new Thread(new ThreadStart(Start));
            thrd.Name = "Start thread";
            thrd.Start();
        }

        private void autoFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rm = new Random();
            Graphics gr = this.panel1.CreateGraphics();
            for (int i = 0; i < WIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    world[i, j] = rm.Next(0, 2);
                    if (world[i, j] == 1)
                        gr.FillRectangle(Brushes.Blue, new Rectangle(i * squareSize, j * squareSize, squareSize, squareSize));
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Функция для подсчёта живых клеток
        private int getLiveCount(int[,] world)
        {
            int count = 0;
            int i, j;
            for (i = 0; i < WIDTH; i++)
            {
                for (j = 0; j < HEIGHT; j++)
                {
                    if (world[i, j] == 1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        /*	Получение координат соседней точки */

        private void readPointNeighbors(int[,] nb, int x, int y)
        {
            int i, j;
            int k = 0;
            for (i = x - 1; i <= x + 1; i++)
            {
                for (j = y - 1; j <= y + 1; j++)
                {
                    if (i == x && j == y)
                    {
                        continue;
                    }
                    nb[k, 0] = i;
                    nb[k, 1] = j;
                    k++;
                }
            }
        }

        /*	Количество живых соседей у клетки с координатами x, y */

        private int countLiveNeighbors(int[,] world, int x, int y)
        {
            int count = 0;
            int i;
            int[,] nb = new int[8, 2];
            int _x, _y;

            readPointNeighbors(nb, x, y);

            for (i = 0; i < 8; i++)
            {
                _x = nb[i, 0];
                _y = nb[i, 1];

                if (_x < 0 || _y < 0)
                {
                    continue;
                }
                if (_x >= WIDTH || _y >= HEIGHT)
                {
                    continue;
                }

                if (world[_x, _y] == 1)
                {
                    count++;
                }
            }

            return count;
        }

        /*	Сгенерировать следующее поколение игрового мира	*/

        private void nextGeneration(int[,] world, int[,] prev_world)
        {
            int i, j;
            int live_nb;
            int p;

            for (i = 0; i < WIDTH; i++)
            {
                for (j = 0; j < HEIGHT; j++)
                {
                    p = prev_world[i, j];
                    live_nb = countLiveNeighbors(prev_world, i, j);

                    if (p == 0)
                    {
                        if (live_nb == 3)
                        {
                            world[i, j] = 1;
                        }
                    }
                    else
                    {
                        if (live_nb < 2 || live_nb > 3)
                        {
                            world[i, j] = 0;
                        }
                    }
                }
            }
        }

        /*	Копирование игрового мира. Используется для сохранения предыдущего поколения	*/

        private void copyWorld(int[,] src, int[,] dest)
        {
            int i, j;
            for (i = 0; i < WIDTH; i++)
            {
                for (j = 0; j < HEIGHT; j++)
                {
                    dest[i, j] = src[i, j];
                }
            }
        }

        /*	Сравнение игровых миров текущего и предыдущего поколения	*/

        private bool cmpWorld(int[,] w1, int[,] w2)
        {
            int i, j;
            for (i = 0; i < WIDTH; i++)
            {
                for (j = 0; j < HEIGHT; j++)
                {
                    if (w1[i, j] != w2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}