using System.Drawing;
using System.Windows.Forms;

namespace ForTest
{
    public partial class Form2 : Form
    {
        protected float deg1, deg2, deg3;

        #region Properties

        public float Deg1
        {
            get { return deg1; }
            set { deg1 = value; }
        }

        public float Deg2
        {
            get { return deg2; }
            set { deg2 = value; }
        }

        public float Deg3
        {
            get { return deg3; }
            set { deg3 = value; }
        }

        #endregion Properties

        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Rectangle rect = new Rectangle(50, 25, 200, 200);
            gr.FillPie(Brushes.SeaGreen, rect, 0, deg1);
            gr.FillPie(Brushes.OrangeRed, rect, deg1, deg2);
            gr.FillPie(Brushes.Aqua, rect, deg1 + deg2, deg3);
        }
    }
}