using System.ComponentModel.Design;
using System.Runtime.Versioning;

namespace FinalProjectITEC140
{
    public partial class Form1 : Form
    {
        Bitmap Neutral = new Bitmap("../../../resources/NeutralPikachu.jpg");
        Bitmap Poopin = new Bitmap("../../../resources/PoopinPikachu.jpg");
        Bitmap Hungry = new Bitmap("../../../resources/HungryPikachu.jpg");
        Bitmap Fainted = new Bitmap("../../../resources/FaintedPikachu.jpg");
        Bitmap Extatic = new Bitmap("../../../resources/ExtaticPikachu.jpg");
        Bitmap Happy = new Bitmap("../../../resources/HappyPikachu.jpg");
        Bitmap Nervous = new Bitmap("../../../resources/NervousPikachu.jpg");
        Bitmap Sad = new Bitmap("../../../resources/SadPikachu.jpg");
        Bitmap Angry = new Bitmap("../../../resources/AngryPikachu.jpg");
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
            picMoods.Image = Neutral;
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
            if (btnPlay.Enabled == true && prbHappiness.Value < 85)
            {
                prbHappiness.Value += 15;
            }
            else if (btnPlay.Enabled == true && prbHappiness.Value > 85)
            {
                prbHappiness.Value = 100;
            }
            picMoods.Image = Happy;
        }

        private void btnPlay_MouseUp(object sender, MouseEventArgs e)
        {
            picMoods.Image = Neutral;
        }

        private void btnBathRoom_MouseDown(object sender, MouseEventArgs e)
        {
            picMoods.Image = Poopin;
            if (btnBathRoom.Enabled && prbPee.Value > 30)
            {
                prbPee.Value -= 30;
            }
            else if (btnBathRoom.Enabled == true && prbPee.Value < 30)
            {
                prbPee.Value = 0;
            }
        }

        private void btnBathRoom_MouseUp(object sender, MouseEventArgs e)
        {
            picMoods.Image = Neutral;
        }
        private void btnPet_MouseDown(object sender, MouseEventArgs e)
        {
            if (btnPet.Enabled == true && prbHappiness.Value < 100)
            {
                prbHappiness.Value += 5;
            }
            else if (btnPet.Enabled == true && prbHappiness.Value > 95)
            {
                prbHappiness.Value = 100;
            }
            picMoods.Image = Happy;
        }

        private void btnPet_MouseUp(object sender, MouseEventArgs e)
        {
            picMoods.Image = Neutral;
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
            if (prbHealth.Value == 0)
            {
                picMoods.Image = Fainted;
                prbHealth.Value = 0;
                prbHappiness.Value = 0;
                prbHunger.Value = 0;
                prbPee.Value = 0;
                MessageBox.Show("You let your Pikachu faint!");
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
            MessageBox.Show("Should look after your Pikachu better!");
        }
        void TrainernearingDeath()
        {
            if (prbHealth.Value <= 75)
            {
                picMoods.Image = Angry;
                prbTrainerHealth.Visible = true;
                lblTrainerHealth.Visible = true;
                BattleTImer.Enabled = true;
                lblTrainerHealth.Text = "TRAINER HEALTH: " + prbTrainerHealth.Value.ToString();
            }
            else if (prbHealth.Value <= 75 && picEvolution.Visible == true) 
            {
                //picMoods.Image = Angry; needs to be a riachu image 
                prbTrainerHealth.Visible = true;
                lblTrainerHealth.Visible = true;
                BattleTImer.Enabled = true;
                lblTrainerHealth.Text = "TRAINER HEALTH: " + prbTrainerHealth.Value.ToString();
            }
            else if (prbHealth.Value > 75)
            {
                BattleTImer.Enabled = false;
            }
        }
        void PokemonHungry()
        {
            if (prbHunger.Value <= 30)
            {
                picMoods.Image = Hungry;
            }
            else if (prbHunger.Value <= 30 && picEvolution.Visible == true) 
            {
                //angry raichu
            }

        }
        void pikachuNervous()
        {
            if (prbHappiness.Value <= 30 && prbHunger.Value <= 20 && prbPee.Value >= 80)
            {
                picMoods.Image = Nervous;
            }
        }

        void pikachuSad()
        {
            if (prbHappiness.Value == 0 && prbHunger.Value == 0 && prbPee.Value == 100 && prbHealth.Value > 75 && prbHealth.Value < 100)
            {
                picMoods.Image = Sad;
            }
            else
            {
                picMoods.Image = Neutral;
            }
        }
        void pikachuExtatic()
        {
            if (prbHappiness.Value > 80 && prbHunger.Value > 40 && prbPee.Value < 70 && prbHealth.Value == 100)
            {
                picMoods.Image = Extatic;
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
    }
}
