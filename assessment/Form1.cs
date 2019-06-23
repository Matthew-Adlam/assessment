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
        // hi
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

        int[] planetSpeed = new int[6];

        Random Speed = new Random();

        Image robber = Image.FromFile(Application.StartupPath + @"\robber.png");
        Image cop = Image.FromFile(Application.StartupPath + @"\police.png");
        int x2 = 50, y2 = 290; // starting position of robber

        public Form1()
        {
            InitializeComponent();
            areaRobber = new Rectangle(x2, y2, 75, 75);
            for (int i = 0; i < 6; i++)
            {
                area[i] = new Rectangle(y + 70 * i, x, 40, 40);
                planetSpeed[i] = Speed.Next(5, 10);
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

            for(int i = 0; i > 5; i++)
            {
                g.DrawImage(cop, area[i]);
            }
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
