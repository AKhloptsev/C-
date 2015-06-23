using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForTest
{
    public partial class Form1 : Form
    {
        const int SEGMENT = 20; // for drawing segments on the coordinate axes
        Panel panel1;
        PointF[] myPoint = new PointF[4];
        int count = 0;  // for count clicks
        Triangle T;
        float S1, S2, S3, S4;   // area of triangles
        int prevX, prevY;   // previous coordinates of size.x and size.y
        bool flag = false, bFlag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw(PaintEventArgs e)
        {
            /* draw panel and axes */
            int w = this.Size.Width;
            int h = this.Size.Height;
            panel1.Size = new Size(w, h);
            Graphics gr = panel1.CreateGraphics();
            int x = panel1.Size.Width;
            int y = panel1.Size.Height;
            int a = x / 2;
            int b = y / 2;
            gr.DrawLine(Pens.DarkBlue, a, 0, a, y);
            gr.DrawLine(Pens.DarkBlue, 0, b, x, b);
            
            // draw division
            #region drawDevision
            for (int i = a + SEGMENT; i < x; i += SEGMENT)
            {
                gr.DrawLine(Pens.Black, i, b + 3, i, b - 3);
            }

            for (int i = a - SEGMENT; i > 0; i -= SEGMENT)
            {
                gr.DrawLine(Pens.Black, i, b + 3, i, b - 3);
            }

            for (int i = b + SEGMENT; i < y; i += SEGMENT)
            {
                gr.DrawLine(Pens.Black, a + 3, i, a - 3, i);
            }

            for (int i = b - SEGMENT; i > 0; i -= SEGMENT)
            {
                gr.DrawLine(Pens.Black, a + 3, i, a - 3, i);
            }
            #endregion

            float difX, difY;
            if (flag)
            {
                difX = Convert.ToSingle(w - prevX); // the difference between the previous and the current size
                difY = Convert.ToSingle(h - prevY);
                difX /= 2.0f;
                difY /= 2.0f;
                prevX = w;  // new current size
                prevY = h;
                // calculate new point
                for (int i = 0; i < 4; i++)
                {
                    myPoint[i] = new PointF(myPoint[i].X + difX, myPoint[i].Y + difY);
                }
            }
            
            // draw points and lines between them
            #region drawLines
            // draw points
            char name = 'A';
            for (int i = 0; i < 4; i++)
            {
                Font drawFont = new Font("Arial", 14);
                gr.FillRectangle(Brushes.Black, myPoint[i].X, myPoint[i].Y, 5, 5);
                gr.DrawString(name.ToString(), drawFont, Brushes.Black, myPoint[i].X, myPoint[i].Y);
                name++;
            }
            // if numbers of clicks = 3 then draw lines between points
            if (count == 3)
            {
                gr.DrawLine(Pens.SeaGreen, myPoint[0].X, myPoint[0].Y, myPoint[1].X, myPoint[1].Y);
                gr.DrawLine(Pens.OrangeRed, myPoint[1].X, myPoint[1].Y, myPoint[2].X, myPoint[2].Y);
                gr.DrawLine(Pens.Aqua, myPoint[0].X, myPoint[0].Y, myPoint[2].X, myPoint[2].Y);
            }
            // if numbers of clicks more than 4 then draw lines between points
            if (count >= 4)
            {
                T = new Triangle(myPoint[0], myPoint[1], myPoint[2], myPoint[3]);
                gr.DrawLine(Pens.SeaGreen, myPoint[0].X, myPoint[0].Y, myPoint[1].X, myPoint[1].Y);
                gr.DrawLine(Pens.OrangeRed, myPoint[1].X, myPoint[1].Y, myPoint[2].X, myPoint[2].Y);
                gr.DrawLine(Pens.Aqua, myPoint[0].X, myPoint[0].Y, myPoint[2].X, myPoint[2].Y);
                gr.DrawLine(Pens.SeaGreen, myPoint[0].X, myPoint[0].Y, myPoint[3].X, myPoint[3].Y);
                gr.DrawLine(Pens.OrangeRed, myPoint[1].X, myPoint[1].Y, myPoint[3].X, myPoint[3].Y);
                gr.DrawLine(Pens.Aqua, myPoint[2].X, myPoint[2].Y, myPoint[3].X, myPoint[3].Y);
                // if we dont show the chart
                if (!bFlag)
                {
                    // if point in the triangle
                    if (T.Check(out S1, out S2, out S3, out S4))
                    {
                        MessageBox.Show("The point inside the triangle", "#", MessageBoxButtons.OK);
                        float deg1 = Convert.ToSingle((S1 / S4) * 360);
                        float deg2 = Convert.ToSingle((S2 / S4) * 360);
                        float deg3 = Convert.ToSingle((S3 / S4) * 360);
                        // create and show new form2
                        Form2 f2 = new Form2();
                        f2.Deg1 = deg1;
                        f2.Deg2 = deg2;
                        f2.Deg3 = deg3;
                        f2.ShowDialog();
                    }
                    else
                        MessageBox.Show("The point outside of the triangle", "#", MessageBoxButtons.OK);
                    bFlag = true;
                }
                flag = false;
            }
            #endregion
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = this.Size.Width;
            int h = this.Size.Height;
            // create and show new panel
            panel1 = new Panel();
            panel1.Size = new Size(w, h);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.Controls.Add(panel1);
            prevX = w;
            prevY = h;
            for (int i = 0; i < 4; i++)
            {
                myPoint[i] = new PointF(-500f, -500f);
            }
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            flag = true;
            this.Refresh();
            this.Invalidate();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            count++;
            if (count == 1)
                myPoint[0] = new PointF(e.X, e.Y);
            else if (count == 2)
                myPoint[1] = new PointF(e.X, e.Y);
            else if (count == 3)
                myPoint[2] = new PointF(e.X, e.Y);
            else if (count == 4)
                myPoint[3] = new PointF(e.X, e.Y);
            this.Invalidate();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh(); // clean all
            this.Invalidate();
            for (int i = 0; i < 4; i++)
            {
                myPoint[i] = new PointF(-500f, -500f);
            }
            flag = bFlag = false;
            count = 0;
            S1 = S2 = S3 = S4 = 0;
            prevX = prevY = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
