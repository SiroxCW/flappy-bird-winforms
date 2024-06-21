using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappybird
{
    public partial class Form_main : Form
    {
        private static Random rnd = new Random();

        int fallPhysic = 0;
        int score = 0;
        int randomWidthDown = 0;
        int randomWidthUp = 0;
        int maxDistance = 180;
        int minDistance = 120;
        int upHeigt = 553;
        int jumpHeight = -12;
        bool isInvis = false;
        bool gameOver = false;
        double globalSpeed = 1;
        bool firstTick = true;

        public Form_main()
        {
            InitializeComponent();
            string[] lines = System.IO.File.ReadAllLines(@"config.txt");
            fallPhysic = Convert.ToInt32(lines[0]);
            score = Convert.ToInt32(lines[1]);
            randomWidthDown = Convert.ToInt32(lines[2]);
            randomWidthUp = Convert.ToInt32(lines[3]);
            maxDistance = Convert.ToInt32(lines[4]);
            minDistance = Convert.ToInt32(lines[5]);
            upHeigt = Convert.ToInt32(lines[6]);
            jumpHeight = Convert.ToInt32(lines[7]);

        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            timer_main.Start();
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            if (firstTick)
            {
                pictureBox_bird.Top = 230;
                label_gameOver.Text = "3";
                this.Update();
                Thread.Sleep(500);
                label_gameOver.Text = "2";
                this.Update();
                Thread.Sleep(500);
                label_gameOver.Text = "1";
                this.Update();
                Thread.Sleep(500);
                label_gameOver.Visible = false;
                pictureBox_pipeDown1.Visible = true;
                pictureBox_pipeUp1.Visible = true;
                pictureBox_pipeDown2.Visible = true;
                pictureBox_pipeUp2.Visible = true;
                this.Update();
                label_gameOver.Text = "GAME OVER";
                firstTick = false;
                randomWidthDown = rnd.Next(minDistance, maxDistance);
                pictureBox_pipeDown1.Height = randomWidthDown;
                randomWidthUp = rnd.Next(minDistance, maxDistance);
                pictureBox_pipeUp1.Height = randomWidthUp;
                pictureBox_pipeUp1.Top = upHeigt - randomWidthUp;

                randomWidthDown = rnd.Next(minDistance, maxDistance);
                pictureBox_pipeDown2.Height = randomWidthDown;
                randomWidthUp = rnd.Next(minDistance, maxDistance);
                pictureBox_pipeUp2.Height = randomWidthUp;
                pictureBox_pipeUp2.Top = upHeigt - randomWidthUp;

            }
            if (!gameOver)
            {
                if (isInvis)
                {
                    this.Opacity -= 0.01;
                    if (Math.Round(this.Opacity, 2) == 0.01)
                    {
                        isInvis = false;
                    }
                }
                else
                {
                    if (this.Opacity != 1)
                    {
                        this.Opacity += 0.01;
                    }
                }

                if (score == 100)
                {
                    pictureBox_pipeDown1.Visible = false;
                    pictureBox_pipeUp1.Visible = false;
                    pictureBox_pipeDown2.Visible = false;
                    pictureBox_pipeUp2.Visible = false;
                    gameOver = true;
                    label_gameOver.Text = "YOU WIN!";
                    label_gameOver.Visible = true;
                }

                if (pictureBox_pipeDown1.Bounds.IntersectsWith(pictureBox_bird.Bounds) || pictureBox_pipeUp1.Bounds.IntersectsWith(pictureBox_bird.Bounds) || pictureBox_pipeDown2.Bounds.IntersectsWith(pictureBox_bird.Bounds) || pictureBox_pipeUp2.Bounds.IntersectsWith(pictureBox_bird.Bounds))
                {
                    if (pictureBox_pipeDown1.Bounds.IntersectsWith(pictureBox_bird.Bounds) || pictureBox_pipeUp1.Bounds.IntersectsWith(pictureBox_bird.Bounds))
                    {
                        pictureBox_pipeDown2.Visible = false;
                        pictureBox_pipeUp2.Visible = false;
                    }
                    else
                    {
                        pictureBox_pipeDown1.Visible = false;
                        pictureBox_pipeUp1.Visible = false;
                    }
                    gameOver = true;
                    label_gameOver.Visible = true;
                    return;
                }

                if (pictureBox_pipeDown1.Left < -100)
                {
                    score++;
                    if (score % 10 == 0 && score >= 50)
                    {
                        isInvis = true;
                    }
                    maxDistance++;
                    globalSpeed += 0.02;
                    label_speed.Text = $"Speed: {globalSpeed}x";
                    randomWidthDown = rnd.Next(minDistance, maxDistance);
                    pictureBox_pipeDown1.Height = randomWidthDown;
                    pictureBox_pipeDown1.Left = 1627;
                    randomWidthUp = rnd.Next(minDistance, maxDistance);
                    pictureBox_pipeUp1.Height = randomWidthUp;
                    pictureBox_pipeUp1.Left = 1627;
                    pictureBox_pipeUp1.Top = upHeigt - randomWidthUp;
                }

                if (pictureBox_pipeDown2.Left < -100)
                {
                    score++;
                    if (score % 10 == 0 && score >= 50)
                    {
                        isInvis = true;
                    }
                    maxDistance++;
                    globalSpeed += 0.02;
                    label_speed.Text = $"Speed: {globalSpeed}x";
                    randomWidthDown = rnd.Next(minDistance, maxDistance);
                    pictureBox_pipeDown2.Height = randomWidthDown;
                    pictureBox_pipeDown2.Left = 1627;
                    randomWidthUp = rnd.Next(minDistance, maxDistance);
                    pictureBox_pipeUp2.Height = randomWidthUp;
                    pictureBox_pipeUp2.Left = 1627;
                    pictureBox_pipeUp2.Top = upHeigt - randomWidthUp;
                }

                label_score.Text = $"Score: {score}";

                pictureBox_pipeDown1.Left -= (int)Math.Round(10 * globalSpeed);
                pictureBox_pipeUp1.Left -= (int)Math.Round(10 * globalSpeed);
                pictureBox_pipeDown2.Left -= (int)Math.Round(10 * globalSpeed);
                pictureBox_pipeUp2.Left -= (int)Math.Round(10 * globalSpeed);
                if (pictureBox_bird.Top > 570 || pictureBox_bird.Top <= 0)
                {
                    pictureBox_pipeDown1.Visible = false;
                    pictureBox_pipeUp1.Visible = false;
                    pictureBox_pipeDown2.Visible = false;
                    pictureBox_pipeUp2.Visible = false;
                    gameOver = true;
                    label_gameOver.Visible = true;
                    return;
                }

                pictureBox_bird.Top += fallPhysic;
                if (fallPhysic < 15)
                {
                    if (fallPhysic == 0)
                    {
                        pictureBox_bird.Image = Properties.Resources.bird;
                    }
                    fallPhysic += 1;
                }
            }

        }

        private void Form_main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!gameOver)
                {
                    pictureBox_bird.Image = Properties.Resources.bird2;
                    fallPhysic = jumpHeight;
                } else
                {
                    pictureBox_pipeDown1.Visible = false;
                    pictureBox_pipeUp1.Visible = false;
                    pictureBox_pipeDown2.Visible = false;
                    pictureBox_pipeUp2.Visible = false;
                    fallPhysic = 0;
                    pictureBox_bird.Top = 20;
                    pictureBox_pipeDown1.Left = 1342;
                    pictureBox_pipeUp1.Left = 1342;
                    pictureBox_pipeDown2.Left = 489;
                    pictureBox_pipeUp2.Left = 489;
                    score = 0;
                    globalSpeed = 1;
                    isInvis = false;
                    this.Opacity = 1;
                    maxDistance = 170;
                    label_score.Text = $"Score: {score}";
                    label_speed.Text = $"Speed: {globalSpeed}x";
                    gameOver = false;
                    firstTick = true;
                }
            }
        }
    }
}
