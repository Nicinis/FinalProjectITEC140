﻿namespace FinalProjectITEC140
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            prbHealth = new ProgressBar();
            label1 = new Label();
            prbPee = new ProgressBar();
            label2 = new Label();
            prbHunger = new ProgressBar();
            label3 = new Label();
            prbHappiness = new ProgressBar();
            label4 = new Label();
            btnFeed = new Button();
            btnBathRoom = new Button();
            picMoods = new PictureBox();
            btnPlay = new Button();
            btnPet = new Button();
            FoodTimer = new System.Windows.Forms.Timer(components);
            BathroomTimer = new System.Windows.Forms.Timer(components);
            HappinessTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picMoods).BeginInit();
            SuspendLayout();
            // 
            // prbHealth
            // 
            prbHealth.Location = new Point(194, 35);
            prbHealth.Name = "prbHealth";
            prbHealth.Size = new Size(260, 41);
            prbHealth.TabIndex = 0;
            prbHealth.Value = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 35);
            label1.Name = "label1";
            label1.Size = new Size(134, 35);
            label1.TabIndex = 1;
            label1.Text = "HEALTH:";
            label1.Click += label1_Click;
            // 
            // prbPee
            // 
            prbPee.Location = new Point(194, 164);
            prbPee.Name = "prbPee";
            prbPee.Size = new Size(163, 34);
            prbPee.TabIndex = 2;
            prbPee.Value = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 163);
            label2.Name = "label2";
            label2.Size = new Size(76, 35);
            label2.TabIndex = 3;
            label2.Text = "PEE:";
            // 
            // prbHunger
            // 
            prbHunger.Location = new Point(194, 122);
            prbHunger.Name = "prbHunger";
            prbHunger.Size = new Size(221, 34);
            prbHunger.TabIndex = 4;
            prbHunger.Value = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 124);
            label3.Name = "label3";
            label3.Size = new Size(140, 35);
            label3.TabIndex = 5;
            label3.Text = "HUNGER:";
            label3.Click += label3_Click;
            // 
            // prbHappiness
            // 
            prbHappiness.Location = new Point(194, 82);
            prbHappiness.Name = "prbHappiness";
            prbHappiness.Size = new Size(237, 34);
            prbHappiness.TabIndex = 6;
            prbHappiness.Value = 80;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 81);
            label4.Name = "label4";
            label4.Size = new Size(176, 35);
            label4.TabIndex = 7;
            label4.Text = "HAPPINESS:";
            // 
            // btnFeed
            // 
            btnFeed.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFeed.Location = new Point(44, 217);
            btnFeed.Name = "btnFeed";
            btnFeed.Size = new Size(144, 82);
            btnFeed.TabIndex = 8;
            btnFeed.Text = "FEED";
            btnFeed.UseVisualStyleBackColor = true;
            btnFeed.Click += btnFeed_Click;
            btnFeed.MouseDown += btnFeed_MouseDown;
            btnFeed.MouseUp += btnFeed_MouseUp;
            // 
            // btnBathRoom
            // 
            btnBathRoom.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBathRoom.Location = new Point(44, 335);
            btnBathRoom.Name = "btnBathRoom";
            btnBathRoom.Size = new Size(144, 82);
            btnBathRoom.TabIndex = 9;
            btnBathRoom.Text = "TAKE OUTSIDE";
            btnBathRoom.UseVisualStyleBackColor = true;
            btnBathRoom.Click += btnBathRoom_Click;
            btnBathRoom.MouseDown += btnBathRoom_MouseDown;
            btnBathRoom.MouseUp += btnBathRoom_MouseUp;
            // 
            // picMoods
            // 
            picMoods.Location = new Point(194, 217);
            picMoods.Name = "picMoods";
            picMoods.Size = new Size(200, 200);
            picMoods.TabIndex = 10;
            picMoods.TabStop = false;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(400, 217);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(144, 82);
            btnPlay.TabIndex = 11;
            btnPlay.Text = "PLAY";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            btnPlay.MouseDown += btnPlay_MouseDown;
            btnPlay.MouseUp += btnPlay_MouseUp;
            // 
            // btnPet
            // 
            btnPet.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPet.Location = new Point(400, 335);
            btnPet.Name = "btnPet";
            btnPet.Size = new Size(144, 82);
            btnPet.TabIndex = 12;
            btnPet.Text = "PET";
            btnPet.UseVisualStyleBackColor = true;
            btnPet.Click += btnPet_Click;
            // 
            // FoodTimer
            // 
            FoodTimer.Interval = 20000;
            FoodTimer.Tick += FoodTimer_Tick;
            // 
            // BathroomTimer
            // 
            BathroomTimer.Interval = 10000;
            BathroomTimer.Tick += BathroomTimer_Tick;
            // 
            // HappinessTimer
            // 
            HappinessTimer.Interval = 15000;
            HappinessTimer.Tick += HappinessTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 536);
            Controls.Add(btnPet);
            Controls.Add(btnPlay);
            Controls.Add(picMoods);
            Controls.Add(btnBathRoom);
            Controls.Add(btnFeed);
            Controls.Add(label4);
            Controls.Add(prbHappiness);
            Controls.Add(label3);
            Controls.Add(prbHunger);
            Controls.Add(label2);
            Controls.Add(prbPee);
            Controls.Add(label1);
            Controls.Add(prbHealth);
            Name = "Form1";
            Text = "Pikachu Petcare";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picMoods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar prbHealth;
        private Label label1;
        private ProgressBar prbPee;
        private Label label2;
        private ProgressBar prbHunger;
        private Label label3;
        private ProgressBar prbHappiness;
        private Label label4;
        private Button btnFeed;
        private Button btnBathRoom;
        private PictureBox picMoods;
        private Button btnPlay;
        private Button btnPet;
        private System.Windows.Forms.Timer FoodTimer;
        private System.Windows.Forms.Timer BathroomTimer;
        private System.Windows.Forms.Timer HappinessTimer;
    }
}
