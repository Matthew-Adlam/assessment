namespace assessment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.medium = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.Button();
            this.TmrRobber = new System.Windows.Forms.Timer(this.components);
            this.TmrCop = new System.Windows.Forms.Timer(this.components);
            this.Instructions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.PictureBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelLives = new System.Windows.Forms.Label();
            this.redeem = new System.Windows.Forms.Label();
            this.redeemCode = new System.Windows.Forms.TextBox();
            this.redeemButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.highScoreLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splashText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.White;
            this.PnlGame.Location = new System.Drawing.Point(12, 67);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(550, 450);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(662, 511);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 38);
            this.back.TabIndex = 15;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Silver;
            this.hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard.Location = new System.Drawing.Point(568, 382);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(183, 59);
            this.hard.TabIndex = 2;
            this.hard.Text = "Hard(1 life)";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // medium
            // 
            this.medium.BackColor = System.Drawing.Color.Silver;
            this.medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medium.Location = new System.Drawing.Point(568, 272);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(183, 59);
            this.medium.TabIndex = 1;
            this.medium.Text = "Medium (2 lives)";
            this.medium.UseVisualStyleBackColor = false;
            this.medium.Click += new System.EventHandler(this.medium_Click);
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.Silver;
            this.easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy.Location = new System.Drawing.Point(568, 158);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(183, 59);
            this.easy.TabIndex = 0;
            this.easy.Text = "Easy ( 3 lives)";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            // 
            // TmrRobber
            // 
            this.TmrRobber.Enabled = true;
            this.TmrRobber.Interval = 50;
            this.TmrRobber.Tick += new System.EventHandler(this.TmrRobber_Tick);
            // 
            // TmrCop
            // 
            this.TmrCop.Enabled = true;
            this.TmrCop.Tick += new System.EventHandler(this.TmrCop_Tick);
            // 
            // Instructions
            // 
            this.Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions.Location = new System.Drawing.Point(613, 160);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(116, 28);
            this.Instructions.TabIndex = 1;
            this.Instructions.Text = "Instructions";
            this.Instructions.UseVisualStyleBackColor = true;
            this.Instructions.Click += new System.EventHandler(this.Instructions_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(613, 99);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(116, 28);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // settings
            // 
            this.settings.BackgroundImage = global::assessment.Properties.Resources.settings;
            this.settings.Image = global::assessment.Properties.Resources.settings;
            this.settings.Location = new System.Drawing.Point(662, 13);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(77, 59);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settings.TabIndex = 5;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(96, 41);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 6;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lives";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(304, 43);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(16, 18);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "0";
            // 
            // labelLives
            // 
            this.labelLives.AutoSize = true;
            this.labelLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLives.Location = new System.Drawing.Point(527, 43);
            this.labelLives.Name = "labelLives";
            this.labelLives.Size = new System.Drawing.Size(16, 18);
            this.labelLives.TabIndex = 9;
            this.labelLives.Text = "0";
            // 
            // redeem
            // 
            this.redeem.AutoSize = true;
            this.redeem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redeem.Location = new System.Drawing.Point(628, 220);
            this.redeem.Name = "redeem";
            this.redeem.Size = new System.Drawing.Size(112, 20);
            this.redeem.TabIndex = 10;
            this.redeem.Text = "Redeem Code";
            // 
            // redeemCode
            // 
            this.redeemCode.Location = new System.Drawing.Point(629, 272);
            this.redeemCode.Name = "redeemCode";
            this.redeemCode.Size = new System.Drawing.Size(100, 20);
            this.redeemCode.TabIndex = 11;
            // 
            // redeemButton
            // 
            this.redeemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redeemButton.Location = new System.Drawing.Point(629, 312);
            this.redeemButton.Name = "redeemButton";
            this.redeemButton.Size = new System.Drawing.Size(100, 38);
            this.redeemButton.TabIndex = 12;
            this.redeemButton.Text = "Redeem!";
            this.redeemButton.UseVisualStyleBackColor = true;
            this.redeemButton.Click += new System.EventHandler(this.redeemButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "High Score";
            // 
            // highScoreLbl
            // 
            this.highScoreLbl.AutoSize = true;
            this.highScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLbl.Location = new System.Drawing.Point(417, 43);
            this.highScoreLbl.Name = "highScoreLbl";
            this.highScoreLbl.Size = new System.Drawing.Size(16, 18);
            this.highScoreLbl.TabIndex = 14;
            this.highScoreLbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(629, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Difficulty";
            // 
            // splashText
            // 
            this.splashText.AutoSize = true;
            this.splashText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashText.Location = new System.Drawing.Point(55, 527);
            this.splashText.Name = "splashText";
            this.splashText.Size = new System.Drawing.Size(47, 25);
            this.splashText.TabIndex = 17;
            this.splashText.Text = "text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splashText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.highScoreLbl);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.redeemButton);
            this.Controls.Add(this.back);
            this.Controls.Add(this.redeemCode);
            this.Controls.Add(this.redeem);
            this.Controls.Add(this.labelLives);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.PnlGame);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrRobber;
        private System.Windows.Forms.Timer TmrCop;
        private System.Windows.Forms.Button Instructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button medium;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelLives;
        private System.Windows.Forms.Label redeem;
        private System.Windows.Forms.TextBox redeemCode;
        private System.Windows.Forms.Button redeemButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label highScoreLbl;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label splashText;
    }
}

