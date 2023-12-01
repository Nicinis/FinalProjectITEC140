namespace FinalProjectITEC140
{
    public partial class Form1 : Form
    {
        Bitmap NeutralPika = new Bitmap("../../../resources/NeutralPika.jpg");
        Bitmap PoopinPika = new Bitmap("../../../resources/PoopinPika.jpg");
        Bitmap FaintedPika = new Bitmap("../../../resources/FaintedPika.jpg");
        Bitmap HappyPika = new Bitmap("../../../resources/HappyPika.jpg");
        Bitmap NervousPika = new Bitmap("../../../resources/NervousPika.jpg");
        Bitmap SadPika = new Bitmap("../../../resources/SadPika.jpg");
        Bitmap AngryPika = new Bitmap("../../../resources/AngryPika.jpg");
        Bitmap NeutralRaichu = new Bitmap("../../../resources/NeutralRaichu.jpg");
        Bitmap PoopinRaichu = new Bitmap("../../../resources/PoopinRaichu.jpg");
        Bitmap FaintedRaichu = new Bitmap("../../../resources/FaintedRaichu.jpg");
        Bitmap HappyRaichu = new Bitmap("../../../resources/HappyRaichu.jpg");
        Bitmap NervousRaichu = new Bitmap("../../../resources/NervousRaichu.jpg");
        Bitmap SadRaichu = new Bitmap("../../../resources/SadRaichu.jpg");
        Bitmap AngryRaichu = new Bitmap("../../../resources/AngryRaichu.jpg");
        public Form1()
        {
            InitializeComponent();

            FoodTimer.Enabled = true;
            BathroomTimer.Enabled = true;
            HappinessTimer.Enabled = true;
            GameTimer.Enabled = true;
            prbTrainerHealth.Visible = false;
            lblTrainerHealth.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picMoods.Image = NeutralPika;
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            if (btnFeed.Enabled == true && prbHunger.Value < 60)
            {
                prbHunger.Value += 10;
            }
            else if (btnFeed.Enabled == true && prbHunger.Value > 50)
            {
                prbHunger.Value = 60;
            }
        }

        private void btnBathRoom_Click(object sender, EventArgs e)
        {

        }

        private void btnPet_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_MouseDown(object sender, MouseEventArgs e)
        {
            if (btnPlay.Enabled == true && prbHappiness.Value < 85 && picEvolution.Visible == false)
            {
                prbHappiness.Value += 15;
                picMoods.Image = HappyPika;
            }
            else if (btnPlay.Enabled == true && prbHappiness.Value > 85 && picEvolution.Visible == false)
            {
                prbHappiness.Value = 100;
                picMoods.Image = HappyPika;
            }
            else if (btnPlay.Enabled == true && prbHappiness.Value < 85 && picEvolution.Visible == true)
            {
                prbHappiness.Value += 15;
                picMoods.Image = HappyRaichu;
            }
            else if (btnPlay.Enabled == true && prbHappiness.Value > 85 && picEvolution.Visible == true)
            {
                prbHappiness.Value = 100;
                picMoods.Image = HappyRaichu;
            }
        }

        private void btnPlay_MouseUp(object sender, MouseEventArgs e)
        {
            if (picEvolution.Visible == true)
            {
                picMoods.Image = NeutralRaichu;
            }
            else
            {
                picMoods.Image = NeutralPika;
            }
        }

        private void btnBathRoom_MouseDown(object sender, MouseEventArgs e)
        {
            picMoods.Image = PoopinPika;
            if (btnBathRoom.Enabled && prbPee.Value > 30 && picEvolution.Visible == false)
            {
                prbPee.Value -= 30;
                picMoods.Image = PoopinPika;
            }
            else if (btnBathRoom.Enabled == true && prbPee.Value < 30 && picEvolution.Visible == false)
            {
                prbPee.Value = 0;
                picMoods.Image = PoopinPika;
            }
            else if (btnBathRoom.Enabled && prbPee.Value > 30 && picEvolution.Visible == true)
            {
                prbPee.Value -= 30;
                picMoods.Image = PoopinRaichu;
            }
            else if (btnBathRoom.Enabled == true && prbPee.Value < 30 && picEvolution.Visible == true)
            {
                prbPee.Value = 0;
                picMoods.Image = PoopinRaichu;
            }
        }

        private void btnBathRoom_MouseUp(object sender, MouseEventArgs e)
        {
            if (picEvolution.Visible == true)
            {
                picMoods.Image = NeutralRaichu;
            }
            else
            {
                picMoods.Image = NeutralPika;
            }
        }
        private void btnPet_MouseDown(object sender, MouseEventArgs e)
        {
            if (btnPet.Enabled == true && prbHappiness.Value < 100 && picEvolution.Visible == false)
            {
                prbHappiness.Value += 5;
                picMoods.Image = HappyPika;
            }
            else if (btnPet.Enabled == true && prbHappiness.Value > 95 && picEvolution.Visible == false)
            {
                prbHappiness.Value = 100;
                picMoods.Image = HappyPika;
            }
            else if (btnPet.Enabled == true && prbHappiness.Value < 100 && picEvolution.Visible == true)
            {
                prbHappiness.Value += 5;
                picMoods.Image = HappyRaichu;
            }
            else if (btnPet.Enabled == true && prbHappiness.Value > 95 && picEvolution.Visible == true)
            {
                prbHappiness.Value = 100;
                picMoods.Image = HappyRaichu;
            }
        }

        private void btnPet_MouseUp(object sender, MouseEventArgs e)
        {
            if (picEvolution.Visible == true)
            {
                picMoods.Image = NeutralRaichu;
            }
            else
            {
                picMoods.Image = NeutralPika;
            }
        }

        private void btnFeed_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnFeed_MouseUp(object sender, MouseEventArgs e)
        {

        }
        private void FoodTimer_Tick(object sender, EventArgs e)
        {
            if (prbHunger.Value > 0)
            {
                prbHunger.Value -= 10;
            }
            else if (prbHunger.Value == 0)
            {
                prbHunger.Value -= 0;
            }
            if (prbHunger.Value == 0 && prbHealth.Value <= 60 && prbHealth.Value > 0)
            {
                prbHealth.Value -= 5;
            }
            else if (prbHunger.Value == 0 && prbHealth.Value == 0)
            {
                prbHealth.Value -= 0;
            }
            TrainernearingDeath();
            Death();
        }

        private void BathroomTimer_Tick(object sender, EventArgs e)
        {
            if (prbPee.Value < 100)
            {
                prbPee.Value += 5;
            }
            else if (prbPee.Value == 100)
            {
                prbPee.Value += 0;
            }
            if (prbPee.Value == 100 && prbHappiness.Value <= 100 && prbHappiness.Value > 0)
            {
                prbHappiness.Value -= 5;
            }
            else if (prbPee.Value == 0 && prbHappiness.Value == 0)
            {
                prbHappiness.Value -= 0;
            }
            if (prbPee.Value == 100 && prbHappiness.Value == 0 && prbHealth.Value <= 100 && prbHealth.Value > 0)
            {
                prbHealth.Value -= 5;
            }
            else if (prbPee.Value == 0 && prbHappiness.Value == 0 && prbHealth.Value == 0)
            {
                prbHealth.Value -= 0;
            }
            TrainernearingDeath();
            Death();
        }

        private void HappinessTimer_Tick(object sender, EventArgs e)
        {
            if (prbHappiness.Value > 0)
            {
                prbHappiness.Value -= 5;
            }
            else if (prbHappiness.Value == 0)
            {
                prbHappiness.Value -= 0;
            }
            if (prbHappiness.Value == 0 && prbHealth.Value <= 100 && prbHealth.Value > 0)
            {
                prbHealth.Value -= 5;
            }
            else if (prbHappiness.Value == 0 && prbHealth.Value == 0)
            {
                prbHealth.Value -= 0;
            }
            TrainernearingDeath();
            Death();
        }
        private void BattleTImer_Tick(object sender, EventArgs e)
        {
            prbTrainerHealth.Value -= 20;
            lblTrainerHealth.Text = "TRAINER HEALTH: " + prbTrainerHealth.Value.ToString();
            if (prbTrainerHealth.Value == 0)
            {
                prbTrainerHealth.Value -= 0;
                trainerDeath();
            }
        }

        void Death()
        {
            if (prbHealth.Value == 0 && picEvolution.Visible == false)
            {
                picMoods.Image = FaintedPika;
                prbHealth.Value = 0;
                prbHappiness.Value = 0;
                prbHunger.Value = 0;
                prbPee.Value = 0;
                MessageBox.Show("You let your Pokemon faint!");
                FoodTimer.Enabled = false;
                BathroomTimer.Enabled = false;
                HappinessTimer.Enabled = false;
                btnBathRoom.Enabled = false;
                btnFeed.Enabled = false;
                btnPlay.Enabled = false;
                btnPet.Enabled = false;
                btnPotion.Enabled = false;
            }
            else if (prbHealth.Value == 0 && picEvolution.Visible == true)
            {
                picMoods.Image = FaintedRaichu;
                prbHealth.Value = 0;
                prbHappiness.Value = 0;
                prbHunger.Value = 0;
                prbPee.Value = 0;
                MessageBox.Show("You let your Pokemon faint!");
                FoodTimer.Enabled = false;
                BathroomTimer.Enabled = false;
                HappinessTimer.Enabled = false;
                btnBathRoom.Enabled = false;
                btnFeed.Enabled = false;
                btnPlay.Enabled = false;
                btnPet.Enabled = false;
                btnPotion.Enabled = false;
            }
        }
        void trainerDeath()
        {
            FoodTimer.Enabled = false;
            BathroomTimer.Enabled = false;
            HappinessTimer.Enabled = false;
            BattleTImer.Enabled = false;
            btnBathRoom.Enabled = false;
            btnFeed.Enabled = false;
            btnPlay.Enabled = false;
            btnPet.Enabled = false;
            btnPotion.Enabled = false;
            MessageBox.Show("Should look after your Pokemon better!");
        }
        void TrainernearingDeath()
        {
            if (prbHealth.Value <= 75)
            {
                picMoods.Image = AngryPika;
                prbTrainerHealth.Visible = true;
                lblTrainerHealth.Visible = true;
                BattleTImer.Enabled = true;
                lblTrainerHealth.Text = "TRAINER HEALTH: " + prbTrainerHealth.Value.ToString();
            }
            else if (prbHealth.Value <= 75 && picEvolution.Visible == true)
            {
                picMoods.Image = AngryRaichu;
                prbTrainerHealth.Visible = true;
                lblTrainerHealth.Visible = true;
                BattleTImer.Enabled = true;
                lblTrainerHealth.Text = "TRAINER HEALTH: " + prbTrainerHealth.Value.ToString();
            }
            else if (prbHealth.Value > 75)
            {
                BattleTImer.Enabled = false;
            }
            fight();

        }

        void PokemonNervous()
        {
            if (prbHappiness.Value <= 30 && prbHunger.Value <= 20 && prbPee.Value >= 80)
            {
                picMoods.Image = NervousPika;
            }
            else if (prbHappiness.Value <= 30 && prbHunger.Value <= 20 && prbPee.Value >= 80 && picEvolution.Visible == true)
            {
                picMoods.Image = NervousRaichu;
            }
        }

        void pikachuSad()
        {
            if (prbHappiness.Value == 0 && prbHunger.Value == 0 && prbPee.Value == 100 && prbHealth.Value > 75 && prbHealth.Value < 100)
            {
                picMoods.Image = SadPika;
            }
            else if (prbHappiness.Value == 0 && prbHunger.Value == 0 && prbPee.Value == 100 && prbHealth.Value > 75 && prbHealth.Value < 100 && picEvolution.Visible == true)
            {
                picMoods.Image = SadRaichu;
            }
        }

        private void btnPotion_Click(object sender, EventArgs e)
        {
            if (btnPotion.Enabled == true && prbHealth.Value < 75)
            {
                prbHealth.Value += 25;
            }
            else if (btnPotion.Enabled == true && prbHealth.Value >= 75)
            {
                prbHealth.Value = 100;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (prbHealth.Value > 90 && prbHappiness.Value > 85 && prbHunger.Value > 40 && prbPee.Value < 40)
            {
                MessageBox.Show("Your Pikachu is EVOLVING!");
                picEvolution.Visible = true;
                if (picEvolution.Visible == true)
                {
                    GameTimer.Enabled = false;
                }
            }
        }
        void fight()
        {

        }
    }
}
