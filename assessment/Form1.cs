using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment
{
    public partial class Form1 : Form
    {
        // declares all variables I need

        Graphics g;
       
        int score = 0;
        int lives = 0;
        int highScore = 0;
        int x = 20;
        int y = 20;
        int difficulty = 3; // 3 easy, 2 medium, 1 hard
        int loadingInt;
        int livesSetBack;
        int scoreSetBack;
        int livesBoost;
        int scoreBoost;
        int requiredScore = 70;
        int x3;
        int y3;

        bool left;
        bool right;
        bool up;
        bool down;

        string name;

        double idc;

        float idk;

        Rectangle areaRobber;
        Rectangle[] area = new Rectangle[6];
        Rectangle coinRectangle;

        int[] copSpeed = new int[6];
        int coinSpeed = 20;

        Random speed = new Random();
        Random loadingScreen = new Random();
        Random coinSpawn = new Random();

        int coinSpawnInt;

        Image robber = Image.FromFile(Application.StartupPath + @"\robber.png");
        Image cop = Image.FromFile(Application.StartupPath + @"\police.png");
       // Image coin = Image.FromFile(Application.StartupPath + @"\coin.jpg");
        int x2 = 350, y2 = 290; // starting position of robber

        public Form1()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });

            areaRobber = new Rectangle(x2, y2, 75, 75);
            for (int i = 0; i < 6; i++)
            {
                area[i] = new Rectangle(x, y + 70 * i, 40, 40);
                copSpeed[i] = speed.Next(1, 15);
            }
            x3 = coinSpawn.Next(0, 450);
            y3 = coinSpawn.Next(0, 550);
            coinRectangle = new Rectangle(x3, y3, 75, 75);
            TmrRobber.Enabled = false;
            TmrCop.Enabled = false;
            easy.Visible = false;
            medium.Visible = false;
            hard.Visible = false;
            back.Visible = false;
            label5.Visible = false;
            splashText.Text = "Welcome to Cop Escape v0.1...";
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

            for(int i = 0; i <= 5; i++)
            {
                g.DrawImage(cop, area[i]);
            }
        }

        private void TmrCop_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 5; i++)
            {
                area[i].X += copSpeed[i];
                if (area[i].IntersectsWith(areaRobber))
                {
                    area[i].X = 20;
                    lives -= 1; // reduce lives by 1
                    labelLives.Text = lives.ToString();
                    if (lives != 0)
                    {
                        splashText.Text = "You only just got away this time";
                    }

                    CheckLives(); //checks to see if the lives is 0
                }
                if (score > 10)
                {
                    copSpeed[i] = speed.Next(5, 20);
                }
                if (score > 25)
                {
                    copSpeed[i] = speed.Next(10, 35);
                }
                if (score > 50)
                {
                    copSpeed[i] = speed.Next(25, 40);
                }

                if (area[i].X > PnlGame.Width)
                {
                    area[i].X = 20;
                    score += 1; // add 1 to score
                    CheckScore();
                    splashText.Text = "Take that silly cop!";
                    labelScore.Text = score.ToString();//display score on the form 
                }
            }
            PnlGame.Invalidate();
        }

        private void Instructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click start to start. Before you do, redeem a code with the redeemer or change your game settings in the Settings menu, and enter a username.");
            MessageBox.Show("Use the arrow keys to move the robber, avoiding the cops. Hit one and you lose a life.");
            MessageBox.Show("If a robber gets to the right of the screen, you gain a point, but try not to lose all your lives!");
            MessageBox.Show("Cops have a large range, larger than their body, as they have hidden guns. Try to stay away from them!");
            MessageBox.Show("Note: This game was not designed to offend anybody.");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            StartGame();
           // CheckLives();
        }

        void CheckLives()
        {
            if(lives == 0 || lives < 0)
            {
                TmrCop.Enabled = false;
                TmrRobber.Enabled = false;
                TmrRobber.Enabled = false;
                MessageBox.Show("Game Over, your score was " + ""+ score + "" + "!");
                splashText.Text = "Noooooooooooooo";

                if (score > highScore)
                {
                    MessageBox.Show("Congratulations, you got a new high score of " + "" + score + "" + "!");
                    highScore = score;
                    highScoreLbl.Text = highScore.ToString();
                }
                Start.Enabled = true;
                Instructions.Enabled = true;
                redeemButton.Enabled = true;
                redeemCode.Enabled = true;
                textName.Enabled = true;

   //             MessageBox.Show("Click the start button to start again!");
            }
        }

        void CheckScore()
        {
            if (score == 70 || score > 70 && difficulty == 3) //checks if it is easy and player has met required score
            {    
                TmrCop.Enabled = false;
                TmrRobber.Enabled = false;
                TmrRobber.Enabled = false;
                MessageBox.Show("Congratulations, you escaped the cops on Easy!" + "Next time, change the difficulty to make it harder!");
            }
            if (score == 100 || score > 100 && difficulty == 2) //checks if it is medium and player has met required score
            {
                TmrCop.Enabled = false;
                TmrRobber.Enabled = false;
                TmrRobber.Enabled = false;
                MessageBox.Show("Congratulations, you escaped the cops on Medium!" + "Next time, change the difficulty to make it harder!");
            }
            if (score == 150 || score > 150 && difficulty == 1) //checks if it is hard and player has met required score
            {
                TmrCop.Enabled = false;
                TmrRobber.Enabled = false;
                TmrRobber.Enabled = false;
                MessageBox.Show("Congratulations, you escaped the cops on Hard!" + "Harder levels coming soon(well maybe)!");
            }
        }

        void StartGame()
        {
            TmrCop.Enabled = true;
            TmrRobber.Enabled = true;

            //makes the arrow keys work
            Start.Enabled = false;
            Instructions.Enabled = false;
            textName.Enabled = false;
            redeemCode.Enabled = false;
            redeemButton.Enabled = false;
            // for the code redeemer
            score = 0 + scoreBoost - scoreSetBack;
            lives = difficulty + livesBoost - livesSetBack;

            labelScore.Text = score.ToString();
            labelLives.Text = lives.ToString();
            
            CheckLives();

            splashText.Text = "And the escape begins!";

        }

        private void settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a difficulty.");
            easy.Enabled = true;
            medium.Enabled = true;
            hard.Enabled = true;
            easy.Visible = true;
            medium.Visible = true;
            hard.Visible = true;
            PnlGame.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            labelScore.Visible = false;
            labelLives.Visible = false;
            redeemButton.Visible = false;
            redeemCode.Visible = false;
            Start.Visible = false;
            Instructions.Visible = false;
            textName.Visible = false;
            highScoreLbl.Visible = false;
            back.Visible = true;
            settings.Visible = false;
            redeem.Visible = false;
        }

        private void easy_Click(object sender, EventArgs e)
        {
            difficulty = 3;
            MessageBox.Show("Difficulty set to Easy. Required score is 70.");
            requiredScore = 70;
            easy.Visible = false;
            medium.Visible = false;
            hard.Visible = false;
            label5.Visible = false;
            back.Visible = false;
            PnlGame.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            labelScore.Visible = true;
            labelLives.Visible = true;
            redeemButton.Visible = true;
            redeemCode.Visible = true;
            Start.Visible = true;
            Instructions.Visible = true;
            textName.Visible = true;
            highScoreLbl.Visible = true;
            back.Visible = false;
            settings.Visible = true;
            redeem.Visible = true;
            splashText.Text = "Taking the easy escape?";
        }

        private void medium_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            MessageBox.Show("Difficulty set to Medium. Required score is 100.");
            requiredScore = 100;
            easy.Visible = false;
            medium.Visible = false;
            hard.Visible = false;
            label5.Visible = false;
            back.Visible = false;
            PnlGame.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            labelScore.Visible = true;
            labelLives.Visible = true;
            redeemButton.Visible = true;
            redeemCode.Visible = true;
            Start.Visible = true;
            Instructions.Visible = true;
            textName.Visible = true;
            highScoreLbl.Visible = true;
            back.Visible = false;
            settings.Visible = true;
            redeem.Visible = true;
            splashText.Text = "Nice medium. Not too hard, not too easy.";
        }

        private void hard_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            MessageBox.Show("Difficulty set to Hard. Required score is 150.");
            requiredScore = 150;
            easy.Visible = false;
            medium.Visible = false;
            hard.Visible = false;
            label5.Visible = false;
            back.Visible = false;
            PnlGame.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
            labelScore.Visible = true;
            labelLives.Visible = true;
            redeemButton.Visible = true;
            redeemCode.Visible = true;
            Start.Visible = true;
            Instructions.Visible = true;
            textName.Visible = true;
            highScoreLbl.Visible = true;
            back.Visible = false;
            settings.Visible = true;
            redeem.Visible = true;
            splashText.Text = "Up for a challenge?";
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

            string context = textName.Text;
            bool isletter = true;
            //for loop checks for letters as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))// if current character not a letter
                {
                    isletter = false;//make isletter false
                    break; // exit the for loop
                }

            }

            // if not a letter clear the textbox and focus on it
            // to enter name again
            if (isletter == false)
            {
                textName.Clear();
                textName.Focus();
                MessageBox.Show("Please enter a valid username - one with only letters");
            }
            else
            {
                Start.Enabled = true;
                Instructions.Enabled = true;
                redeemCode.Enabled = true;
                redeemButton.Enabled = true;
                context = name;
            }

        }

        private void redeemButton_Click(object sender, EventArgs e)
        {
            // codes check if it is entered correctly
            if (redeemCode.Text == "Bomb Tower")
            {
                MessageBox.Show("Say No To Bomb Tower");
                livesSetBack = 4;
            }
            else if (redeemCode.Text == "Matthew Is a God" || redeemCode.Text == "Matthew is a god" || redeemCode.Text == "MATTHEW IS A GOD" || redeemCode.Text == "matthew is a god")
            {
                MessageBox.Show("You Legend! Have a free 50 points!");
                scoreBoost = 50;
            }
            else if (redeemCode.Text == "0987645321")
            {
                MessageBox.Show("Did you see my advert? Have a free 5 points!");
                scoreBoost = 5;
            }
            else if (redeemCode.Text == "Combo Box" || redeemCode.Text == "combo box" || redeemCode.Text == "Combo box")
            {
                MessageBox.Show("COMBO BOX!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                livesBoost = 3;
            }
            else if (redeemCode.Text == "Lmao" || redeemCode.Text == "lmao")
            {
                MessageBox.Show("LMAO");
                scoreSetBack = 2;
            }
            else if (redeemCode.Text == "Dax" || redeemCode.Text == "Ryan")
            {
                MessageBox.Show("Is A God");
                scoreBoost = 50;
            }
            else if (redeemCode.Text == "trololol" || redeemCode.Text == "TROLOLOL")
            {
                MessageBox.Show("t r o l o l o l");
                scoreBoost = 1;
            }
            else if (redeemCode.Text == "TeenJobs" || redeemCode.Text == "TEENJOBS" || redeemCode.Text == "teenjobs")
            {
                MessageBox.Show("Try using Bomb Tower");
                Application.Exit();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            PnlGame.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            labelScore.Visible = true;
            labelLives.Visible = true;
            redeemButton.Visible = true;
            redeemCode.Visible = true;
            redeem.Visible = true;
            Start.Visible = true;
            Instructions.Visible = true;
            textName.Visible = true;
            highScoreLbl.Visible = true;
            easy.Visible = false;
            medium.Visible = false;
            hard.Visible = false;
            back.Visible = false;
            settings.Visible = true;
            label5.Visible = false;
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
                    areaRobber.X -= 7; 
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
