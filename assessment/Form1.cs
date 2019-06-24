using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment
{
    public partial class Form1 : Form
    {
        // declares all I need
        Graphics g;
       
        int score = 0;
        int lives = 0;
        int x = 20;
        int y = 20;

        bool left;
        bool right;
        bool up;
        bool down;

        Rectangle areaRobber;
        Rectangle[] area = new Rectangle[6];

        int[] copSpeed = new int[5];

        Random speed = new Random();

        Image robber = Image.FromFile(Application.StartupPath + @"\robber.png");
        Image cop = Image.FromFile(Application.StartupPath + @"\police.png");
        int x2 = 50, y2 = 290; // starting position of robber

        public Form1()
        {
            InitializeComponent();
            areaRobber = new Rectangle(x2, y2, 75, 75);
            for (int i = 0; i < 5; i++)
            {
                area[i] = new Rectangle(x, y + 70 * i, 40, 40);
                copSpeed[i] = speed.Next(5, 10);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                left = true;
            }
            if (e.KeyData == Keys.Right)
            {
                right = true;
            }
            if (e.KeyData == Keys.Up)
            {
                up = true;
            }
            if (e.KeyData == Keys.Down)
            {
                down = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                left = false;
            }
            if (e.KeyData == Keys.Right)
            {
                right = false;
            }
            if (e.KeyData == Keys.Up)
            {
                up = false;
            }
            if (e.KeyData == Keys.Down)
            {
                down = false;
            }
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            g.DrawImage(robber, areaRobber);

            for(int i = 0; i <= 4; i++)
            {
                g.DrawImage(cop, area[i]);
            }
        }

        private void TmrCop_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++)
            {
                area[i].X += copSpeed[i];
                if (area[i].IntersectsWith(areaRobber))
                {
                    area[i].X = 20;
                    lives -= 1; // reduce lives by 1
                  //  LblLives.Text = lives.ToString();

                //    CheckLives();
                }
                if (score > 20)
                {
                    copSpeed[i] = speed.Next(10, 20);
                }
                if (score > 50)
                {
                    copSpeed[i] = speed.Next(20, 25);
                }
                if (score > 100)
                {
                    copSpeed[i] = speed.Next(25, 40);
                }
                if (score > 200)
                {
                    copSpeed[i] = speed.Next(40, 50);
                }
                if (score > 500)
                {
                    copSpeed[i] = speed.Next(50, 80);
                }
                if (score > 1000)
                {
                    copSpeed[i] = speed.Next(80, 100);
                }

                if (area[i].X > PnlGame.Width)
                {
                    area[i].X = 20;
                    score += 1; // add 1 to score
               //     LblScore.Text = score.ToString();//display score on the form 
                }
            }
            PnlGame.Invalidate();
        }
    

        private void TmrRobber_Tick(object sender, EventArgs e)
        {
            if (left) // if left arrow pressed
            {
                if (areaRobber.X < 10) //check to see if spaceship within 10 of left side
                {
                    areaRobber.X = 10; //if it is < 10 away "bounce" it (set position at 10)
                }
                else
                {
                    areaRobber.X -= 7; //else move 5 to the left
                }
                PnlGame.Invalidate();
            }
            if (right) // if right arrow key pressed
            {
                if (areaRobber.X > PnlGame.Width - 80)// is spaceship within 40 of right side
                {
                    areaRobber.X = PnlGame.Width - 80;
                }
                else
                {
                    areaRobber.X += 7;
                }
                PnlGame.Invalidate();
            }
   
            if (up) 
            {
                if (areaRobber.Y < PnlGame.Height - 430)
                {
                    areaRobber.Y = PnlGame.Height - 430;
                }
                else
                {
                    areaRobber.Y -= 7;
                }
                PnlGame.Invalidate();
            }
         
            if (down)
            {
                if (areaRobber.Y > PnlGame.Height - 80)
                {
                    areaRobber.Y = PnlGame.Height - 80;
                }
                else
                {
                    areaRobber.Y += 7;
                }
                PnlGame.Invalidate();
            }

        }
    }
}
