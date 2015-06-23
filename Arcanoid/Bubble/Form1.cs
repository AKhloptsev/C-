using System;
using System.Windows.Forms;

namespace Bubble
{
    public partial class Form1 : Form
    {
        private int horizontal_speed = 0, vertical_speed = 0;
        private int racket_speed = 25;
        private int score = 0;
        private bool start = false;
        private PictureBox[] brick = new PictureBox[41];
        private PictureBox heart;
        private Random rm = new Random();

        public Form1()
        {
            InitializeComponent();

            #region initPictureBox

            brick[0] = pictureBox1;
            brick[1] = pictureBox2;
            brick[2] = pictureBox3;
            brick[3] = pictureBox4;
            brick[4] = pictureBox5;
            brick[5] = pictureBox6;
            brick[6] = pictureBox7;
            brick[7] = pictureBox8;
            brick[8] = pictureBox9;
            brick[9] = pictureBox10;
            brick[10] = pictureBox11;
            brick[11] = pictureBox12;
            brick[12] = pictureBox13;
            brick[13] = pictureBox14;
            brick[14] = pictureBox15;
            brick[15] = pictureBox16;
            brick[16] = pictureBox17;
            brick[17] = pictureBox18;
            brick[18] = pictureBox19;
            brick[19] = pictureBox20;
            brick[20] = pictureBox21;
            brick[21] = pictureBox22;
            brick[22] = pictureBox23;
            brick[23] = pictureBox24;
            brick[24] = pictureBox25;
            brick[25] = pictureBox26;
            brick[26] = pictureBox27;
            brick[27] = pictureBox28;
            brick[28] = pictureBox29;
            brick[29] = pictureBox30;
            brick[30] = pictureBox31;
            brick[31] = pictureBox32;
            brick[32] = pictureBox33;
            brick[33] = pictureBox34;
            brick[34] = pictureBox35;
            brick[35] = pictureBox36;
            brick[36] = pictureBox37;
            brick[37] = pictureBox38;
            brick[38] = pictureBox39;
            brick[39] = pictureBox40;
            brick[40] = pictureBox41;

            #endregion initPictureBox

            for (int i = 0; i < 41; i++)
            {
                brick[i].Visible = false;
            }
            label_GameStart.Visible = true; // show game start label
            label_GameOver.Visible = false; //hide game over label
            /*  placement labels on board   */
            label_GameStart.Top = background.Bottom / 2 - label_GameStart.Size.Height + 125;
            label_GameStart.Left = background.Right / 2 - label_GameStart.Size.Width / 2;
            label_GameOver.Top = background.Bottom / 2 - label_GameOver.Size.Height + 75;
            label_GameOver.Left = background.Right / 2 - label_GameOver.Size.Width / 2;
            label_score.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ball movement
            ball.Left += horizontal_speed;
            ball.Top += vertical_speed;

            // if the ball hit the brick
            for (int i = 0; i < 41; i++)
            {
                if (ball.Top >= brick[i].Top && ball.Top <= brick[i].Bottom &&
                ball.Left >= (brick[i].Left - ball.Size.Width / 2) && ball.Right <= (brick[i].Right + ball.Size.Width / 2))
                {
                    /*     If the brick still had last hit     */
                    if ((int)brick[i].Tag == 1)
                    {
                        brick[i].Tag = 0;
                        brick[i].Visible = false;
                        horizontal_speed = -horizontal_speed;
                        score += 10;
                        horizontal_speed += rm.Next(-2, 3);
                        vertical_speed = -vertical_speed;
                        label_score.Text = score.ToString();
                        break;
                    }
                    /*     If the brick still had 2 hits     */
                    if ((int)brick[i].Tag == 2)
                    {
                        brick[i].Tag = 1;
                        horizontal_speed = -horizontal_speed;
                        horizontal_speed += rm.Next(-2, 3);
                        vertical_speed = -vertical_speed;
                        score += 10;
                        label_score.Text = score.ToString();
                        break;
                    }
                }
            }

            // if the ball hit the heart
            if (ball.Bottom >= heart.Top && ball.Bottom <= heart.Bottom &&
                ball.Left >= (heart.Left - ball.Size.Width / 2) && ball.Right <= (heart.Right + ball.Size.Width / 2))
            {
                timer1.Enabled = false;
                heart.Visible = false;
                start = false;
                MessageBox.Show("You WIN!!!");
                label_GameOver.Visible = true;
            }

            // if the ball hit the racket
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom &&
                ball.Left >= (racket.Left - ball.Size.Width / 2) && ball.Right <= (racket.Right + ball.Size.Width / 2))
            {
                score++;
                vertical_speed = -vertical_speed;
                // todo
                // use another logic hitting the ball
                horizontal_speed += rm.Next(-1, 1);
                vertical_speed += rm.Next(-1, 2);
                label_score.Text = score.ToString();
                if (horizontal_speed >= 8 || horizontal_speed <= -8)
                    horizontal_speed = rm.Next(0, 4);
                if (vertical_speed >= 8 || vertical_speed <= -8)
                    horizontal_speed = rm.Next(3, 7);
            }
            // if the ball hit the border
            if (ball.Top <= background.Top)
                vertical_speed = -vertical_speed;
            if (ball.Right >= background.Right)
                horizontal_speed = -horizontal_speed;
            if (ball.Left <= background.Left)
                horizontal_speed = -horizontal_speed;
            // if game over
            if (ball.Bottom >= background.Bottom)
            {
                timer1.Enabled = false;
                start = false;
                label_GameOver.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();

            // if press Space(start game)
            if (e.KeyData == Keys.Space && !start)
            {
                // select speed and cleaning of all variables
                horizontal_speed = 2;
                vertical_speed = 4;
                for (int i = 0; i < 41; i++)
                {
                    brick[i].Visible = true;
                }
                for (int i = 0; i < 30; i++)
                {
                    brick[i].Tag = 1;
                }
                for (int i = 30; i < 41; i++)
                {
                    brick[i].Tag = 2;
                }
                heart = star;
                heart.Tag = 1;
                heart.Visible = true;
                score = 0;
                label_score.Text = "0";
                racket.Top = background.Bottom - label_score.Size.Height - racket.Size.Height;
                racket.Left = background.Right / 2 - racket.Size.Width / 2;
                ball.Top = background.Bottom - label_score.Size.Height - racket.Size.Height - ball.Size.Height - 10;
                ball.Left = background.Right / 2 - ball.Size.Width / 2;
                label_GameOver.Visible = false;
                start = true;
                label_GameStart.Visible = false;
                timer1.Enabled = true;
            }
            if (start)
            {
                // if press left or right
                if (e.KeyData == Keys.Left)
                {
                    if (racket.Left >= background.Left)
                        racket.Left -= racket_speed;
                }
                if (e.KeyData == Keys.Right)
                {
                    if (racket.Right <= background.Right)
                        racket.Left += racket_speed;
                }
            }
        }
    }
}