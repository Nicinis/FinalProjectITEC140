namespace FinalProjectITEC140
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
            btnExit = new Button();
            prbTrainerHealth = new ProgressBar();
            lblTrainerHealth = new Label();
            BattleTImer = new System.Windows.Forms.Timer(components);
            btnPotion = new Button();
            ((System.ComponentModel.ISupportInitialize)picMoods).BeginInit();
            SuspendLayout();
            // 
            // prbHealth
            // 
            prbHealth.Location = new Point(136, 21);
            prbHealth.Margin = new Padding(2);
            prbHealth.Name = "prbHealth";
            prbHealth.Size = new Size(182, 25);
            prbHealth.TabIndex = 0;
            prbHealth.Value = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 1;
            label1.Text = "HEALTH:";
            label1.Click += label1_Click;
            // 
            // prbPee
            // 
            prbPee.Location = new Point(136, 98);
            prbPee.Margin = new Padding(2);
            prbPee.Name = "prbPee";
            prbPee.Size = new Size(114, 20);
            prbPee.TabIndex = 2;
            prbPee.Value = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 3;
            label2.Text = "PEE:";
            // 
            // prbHunger
            // 
            prbHunger.Location = new Point(136, 73);
            prbHunger.Margin = new Padding(2);
            prbHunger.Maximum = 60;
            prbHunger.Name = "prbHunger";
            prbHunger.Size = new Size(152, 20);
            prbHunger.Style = ProgressBarStyle.Continuous;
            prbHunger.TabIndex = 4;
            prbHunger.Value = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 74);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 5;
            label3.Text = "HUNGER:";
            label3.Click += label3_Click;
            // 
            // prbHappiness
            // 
            prbHappiness.Location = new Point(136, 49);
            prbHappiness.Margin = new Padding(2);
            prbHappiness.Name = "prbHappiness";
            prbHappiness.Size = new Size(166, 20);
            prbHappiness.TabIndex = 6;
            prbHappiness.Value = 80;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 49);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 7;
            label4.Text = "HAPPINESS:";
            // 
            // btnFeed
            // 
            btnFeed.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnFeed.Location = new Point(31, 259);
            btnFeed.Margin = new Padding(2);
            btnFeed.Name = "btnFeed";
            btnFeed.Size = new Size(101, 71);
            btnFeed.TabIndex = 8;
            btnFeed.Text = "FEED";
            btnFeed.UseVisualStyleBackColor = true;
            btnFeed.Click += btnFeed_Click;
            btnFeed.MouseDown += btnFeed_MouseDown;
            btnFeed.MouseUp += btnFeed_MouseUp;
            // 
            // btnBathRoom
            // 
            btnBathRoom.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBathRoom.Location = new Point(31, 130);
            btnBathRoom.Margin = new Padding(2);
            btnBathRoom.Name = "btnBathRoom";
            btnBathRoom.Size = new Size(101, 71);
            btnBathRoom.TabIndex = 9;
            btnBathRoom.Text = "TAKE OUTSIDE";
            btnBathRoom.UseVisualStyleBackColor = true;
            btnBathRoom.Click += btnBathRoom_Click;
            btnBathRoom.MouseDown += btnBathRoom_MouseDown;
            btnBathRoom.MouseUp += btnBathRoom_MouseUp;
            // 
            // picMoods
            // 
            picMoods.Location = new Point(136, 130);
            picMoods.Margin = new Padding(2);
            picMoods.Name = "picMoods";
            picMoods.Size = new Size(200, 200);
            picMoods.TabIndex = 10;
            picMoods.TabStop = false;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlay.Location = new Point(340, 259);
            btnPlay.Margin = new Padding(2);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(101, 71);
            btnPlay.TabIndex = 11;
            btnPlay.Text = "PLAY";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            btnPlay.MouseDown += btnPlay_MouseDown;
            btnPlay.MouseUp += btnPlay_MouseUp;
            // 
            // btnPet
            // 
            btnPet.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPet.Location = new Point(340, 130);
            btnPet.Margin = new Padding(2);
            btnPet.Name = "btnPet";
            btnPet.Size = new Size(101, 71);
            btnPet.TabIndex = 12;
            btnPet.Text = "PET";
            btnPet.UseVisualStyleBackColor = true;
            btnPet.Click += btnPet_Click;
            btnPet.MouseDown += btnPet_MouseDown;
            btnPet.MouseUp += btnPet_MouseUp;
            // 
            // FoodTimer
            // 
            FoodTimer.Interval = 20000;
            FoodTimer.Tick += FoodTimer_Tick;
            // 
            // BathroomTimer
            // 
            BathroomTimer.Interval = 8000;
            BathroomTimer.Tick += BathroomTimer_Tick;
            // 
            // HappinessTimer
            // 
            HappinessTimer.Interval = 12000;
            HappinessTimer.Tick += HappinessTimer_Tick;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(339, 22);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(45, 23);
            btnExit.TabIndex = 13;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // prbTrainerHealth
            // 
            prbTrainerHealth.Location = new Point(243, 335);
            prbTrainerHealth.Maximum = 160;
            prbTrainerHealth.Name = "prbTrainerHealth";
            prbTrainerHealth.Size = new Size(198, 23);
            prbTrainerHealth.TabIndex = 14;
            prbTrainerHealth.Value = 160;
            // 
            // lblTrainerHealth
            // 
            lblTrainerHealth.AutoSize = true;
            lblTrainerHealth.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTrainerHealth.Location = new Point(32, 335);
            lblTrainerHealth.Margin = new Padding(2, 0, 2, 0);
            lblTrainerHealth.Name = "lblTrainerHealth";
            lblTrainerHealth.Size = new Size(177, 23);
            lblTrainerHealth.TabIndex = 15;
            lblTrainerHealth.Text = "TRAINER HEALTH:";
            // 
            // BattleTImer
            // 
            BattleTImer.Interval = 5000;
            BattleTImer.Tick += BattleTImer_Tick;
            // 
            // btnPotion
            // 
            btnPotion.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPotion.Location = new Point(31, 206);
            btnPotion.Name = "btnPotion";
            btnPotion.Size = new Size(100, 48);
            btnPotion.TabIndex = 16;
            btnPotion.Text = "POTION";
            btnPotion.UseVisualStyleBackColor = true;
            btnPotion.Click += btnPotion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 403);
            Controls.Add(btnPotion);
            Controls.Add(lblTrainerHealth);
            Controls.Add(prbTrainerHealth);
            Controls.Add(btnExit);
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
            Margin = new Padding(2);
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
        private Button btnExit;
        private ProgressBar prbTrainerHealth;
        private Label lblTrainerHealth;
        private System.Windows.Forms.Timer BattleTImer;
        private Button btnPotion;
    }
}
