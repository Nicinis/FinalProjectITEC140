using System.Diagnostics.Eventing.Reader;
using System.Media;

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
        SoundPlayer pikaaa = new SoundPlayer("../../../resources/Pikaaa.wav");
        SoundPlayer click = new SoundPlayer("../../../resources/btnClick.wav");
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
            pikaaa.Play();
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            click.Play();
            if (btnFeed.Enabled == true && prbHunger.Value < 40)
            {
                prbHunger.Value += 20;
            }
            else if (btnFeed.Enabled == true && prbHunger.Value >= 40)
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
            click.Play();
            if (btnPlay.Enabled == true && prbHappiness.Value < 85 && picEvolution.Visible == false)
            {
                prbHappiness.Value += 15;
                picMoods.Image = HappyPika;
            }
            else if (btnPlay.Enabled == true && prbHappiness.Value >= 85 && picEvolution.Visible == false)
            {
                prbHappiness.Value = 100;
                picMoods.Image = HappyPika;
            }
            else if (btnPlay.Enabled == true && prbHappiness.Value < 85 && picEvolution.Visible == true)
            {
                prbHappiness.Value += 15;
                picMoods.Image = HappyRaichu;
            }
            else if (btnPlay.Enabled == true && prbHappiness.Value >= 85 && picEvolution.Visible == true)
            {
                prbHappiness.Value = 100;
                picMoods.Image = HappyRaichu;
            }
            PokemonAngry();

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
            PokemonAngry();
            PokemonHappy();
            PokemonNeutral();
            PokemonNervous();
            PokemonSad();

        }

        private void btnBathRoom_MouseDown(object sender, MouseEventArgs e)
        {
            click.Play();
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
            PokemonAngry();
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
            PokemonAngry();
            PokemonHappy();
            PokemonNeutral();
            PokemonNervous();
            PokemonSad();
        }
        private void btnPet_MouseDown(object sender, MouseEventArgs e)
        {
            click.Play();
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
            PokemonAngry();

        }

        private void btnPet_MouseUp(object sender, MouseEventArgs e)
        {
            if (picEvolution.Visible == true)
            {
                picMoods.Image = NeutralRaichu;
            }
            else if (picEvolution.Visible == false)
            {
                picMoods.Image = NeutralPika;
            }
            PokemonAngry();
            PokemonHappy();
            PokemonNeutral();
            PokemonNervous();
            PokemonSad();
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
            PokemonRevenge();
            PokemonDeath();
            PokemonHappy();
            PokemonNeutral();
            PokemonNervous();
            PokemonSad();
            PokemonAngry();
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
            PokemonRevenge();
            PokemonDeath();
            PokemonHappy();
            PokemonNeutral();
            PokemonNervous();
            PokemonSad();
            PokemonAngry();
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
            PokemonRevenge();
            PokemonDeath();
            PokemonHappy();
            PokemonNeutral();
            PokemonNervous();
            PokemonSad();
            PokemonAngry();
        }
        private void BattleTimer_Tick(object sender, EventArgs e)
        {
            if (picEvolution.Visible == true)
            {
                prbTrainerHealth.Value -= 20;
                lblTrainerHealth.Text = "TRAINER HEALTH: " + prbTrainerHealth.Value.ToString();
                if (prbTrainerHealth.Value == 0)
                {
                    prbTrainerHealth.Value -= 0;
                    TrainerDeath();
                }
            }
            else if (picEvolution.Visible == false)
            {
                prbTrainerHealth.Value -= 10;
                lblTrainerHealth.Text = "TRAINER HEALTH: " + prbTrainerHealth.Value.ToString();
                if (prbTrainerHealth.Value == 0)
                {
                    prbTrainerHealth.Value -= 0;
                    TrainerDeath();
                }
            }

        }

        void PokemonDeath()
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
                BattleTImer.Enabled = false;
                GameTimer.Enabled = false;
                btnBathRoom.Enabled = false;
                btnHelp.Enabled = false;
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
                BattleTImer.Enabled = false;
                GameTimer.Enabled = false;
                btnBathRoom.Enabled = false;
                btnHelp.Enabled = false;
                btnFeed.Enabled = false;
                btnPlay.Enabled = false;
                btnPet.Enabled = false;
                btnPotion.Enabled = false;
            }
        }
        void TrainerDeath()
        {
            FoodTimer.Enabled = false;
            BathroomTimer.Enabled = false;
            HappinessTimer.Enabled = false;
            BattleTImer.Enabled = false;
            GameTimer.Enabled = false;
            btnHelp.Enabled = false;
            btnBathRoom.Enabled = false;
            btnFeed.Enabled = false;
            btnPlay.Enabled = false;
            btnPet.Enabled = false;
            btnPotion.Enabled = false;
            MessageBox.Show("Your Pokemon knocked you unconcious! You Should look after your Pokemon better!");
        }
        void PokemonRevenge()
        {
            if (prbHealth.Value <= 75 && picEvolution.Visible == false)
            {
                picMoods.Image = AngryPika;
                prbTrainerHealth.Visible = true;
                lblTrainerHealth.Visible = true;
                lblTrainerHealth.Text = "TRAINER HEALTH: " + prbTrainerHealth.Value.ToString();
                BattleTImer.Enabled = true;
            }
            else if (prbHealth.Value <= 75 && picEvolution.Visible == true)
            {
                picMoods.Image = AngryRaichu;
                prbTrainerHealth.Visible = true;
                lblTrainerHealth.Visible = true;
                lblTrainerHealth.Text = "TRAINER HEALTH: " + prbTrainerHealth.Value.ToString();
                BattleTImer.Enabled = true;
            }
            else if (prbHealth.Value > 75)
            {
                BattleTImer.Enabled = false;
            }

        }
        void PokemonNeutral()
        {
            if (prbHappiness.Value < 85 && prbHunger.Value < 40 && prbPee.Value > 30 && picEvolution.Visible == false)
            {
                picMoods.Image = NeutralPika;
            }
            else if (prbHappiness.Value < 85 && prbHunger.Value < 40 && prbPee.Value > 30 && picEvolution.Visible == true)
            {
                picMoods.Image = NeutralRaichu;
            }
        }
        void PokemonNervous()
        {
            if (prbHappiness.Value < 60 && prbHunger.Value < 20 && prbPee.Value > 50 && picEvolution.Visible == false)
            {
                picMoods.Image = NervousPika;
            }
            else if (prbHappiness.Value < 60 && prbHunger.Value < 20 && prbPee.Value > 50 && picEvolution.Visible == true)
            {
                picMoods.Image = NervousRaichu;
            }
        }

        void PokemonSad()
        {
            if ((prbHappiness.Value == 0 || prbHunger.Value == 0) && prbPee.Value > 80 && prbHealth.Value > 75 && prbHealth.Value < 100 && picEvolution.Visible == false)
            {
                picMoods.Image = SadPika;
            }
            else if ((prbHappiness.Value == 0 || prbHunger.Value == 0) && prbPee.Value > 80 && prbHealth.Value > 75 && prbHealth.Value < 100 && picEvolution.Visible == true)
            {
                picMoods.Image = SadRaichu;
            }
        }
        void PokemonHappy()
        {
            if (prbHealth.Value >= 90 && prbHappiness.Value >= 85 && prbHunger.Value >= 40 && prbPee.Value <= 40 && picEvolution.Visible == false)
            {
                picMoods.Image = HappyPika;
            }
            else if (prbHealth.Value >= 90 && prbHappiness.Value >= 85 && prbHunger.Value >= 40 && prbPee.Value <= 40 && picEvolution.Visible == true)
            {
                picMoods.Image = HappyRaichu;
            }
        }
        void PokemonAngry()
        {
            if (BattleTImer.Enabled == true && picEvolution.Visible == false)
            {
                picMoods.Image = AngryPika;
                if (BattleTImer.Enabled == false && picEvolution.Visible == false)
                {
                    picMoods.Image = NeutralPika;
                }
            }
            else if (BattleTImer.Enabled == true && picEvolution.Visible == true)
            {
                picMoods.Image = AngryRaichu;
                if (BattleTImer.Enabled == false && picEvolution.Visible == true)
                {
                    picMoods.Image = NeutralRaichu;
                }
            }
        }
        private void btnPotion_Click(object sender, EventArgs e)
        {
            click.Play();
            if (btnPotion.Enabled == true && prbHealth.Value < 75)
            {
                prbHealth.Value += 25;
            }
            else if (btnPotion.Enabled == true && prbHealth.Value >= 75)
            {
                prbHealth.Value = 100;
            }
            PokemonHappy();
            PokemonNeutral();
            PokemonNervous();
            PokemonSad();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (prbHealth.Value > 90 && prbHappiness.Value > 85 && prbHunger.Value >= 40 && prbPee.Value < 40)
            {
                MessageBox.Show("Your Pikachu is EVOLVING!");
                picEvolution.Visible = true;
                PokemonHappy();
                if (picEvolution.Visible == true)
                {
                    GameTimer.Enabled = false;
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            click.Play();
            MessageBox.Show("Naturally you have to look after your pets. Taking them to the BATHROOM and making sure they stay FED and HAPPY. If not, your Pokemon just might become upset with you!");
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            click.Play();
            MessageBox.Show("Created by NicK Z.");
        }

        private void lblTrainerHealth_Click(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            click.Play();
            if (picMoods.Image == FaintedPika || picMoods.Image == FaintedRaichu)
            {
                MessageBox.Show("Shame on you for leaving your Pokemon behind!");
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
