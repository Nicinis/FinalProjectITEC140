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
        public Form1()
        {
            InitializeComponent();
            FoodTimer.Enabled = true;
            BathroomTimer.Enabled = true;
            HappinessTimer.Enabled = true;
            if (prbHealth.Value == 0)
            {
                picMoods.Image = Fainted;
                MessageBox.Show("Pikachu has fainted");
            }

            if (prbHappiness.Value >= 80 && prbHealth.Value >= 80 && prbHunger.Value >= 80 && prbPee.Value <= 20)
            {
                picMoods.Image = Extatic;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void btnFeed_Click(object sender, EventArgs e)
        {

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

        }

        private void btnPlay_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnBathRoom_MouseDown(object sender, MouseEventArgs e)
        {
            picMoods.Image = Poopin;
        }

        private void btnBathRoom_MouseUp(object sender, MouseEventArgs e)
        {
            picMoods.Image = Neutral;
            prbPee.Value -= 50;
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
                prbHunger.Value -= 5;
            }
            else if (prbHunger.Value == 0)
            {
                prbHunger.Value -= 0;
            }
            if (prbHunger.Value == 0)
            {
                prbHealth.Value -= 5;
            }
            else if (prbHealth.Value == 0)
            {
                prbHealth.Value -= 0;
            }

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
            if (prbPee.Value == 100 && prbHappiness.Value < 100 && prbHappiness.Value > 0)
            {
                prbHappiness.Value -= 5;
            }
            else if (prbPee.Value == 0 && prbHappiness.Value == 0)
            {
                prbHappiness.Value -= 0;
            }
            if (prbPee.Value == 100 && prbHappiness.Value == 0 && prbHealth.Value < 100 && prbHealth.Value > 0) 
            {  
                prbHealth.Value -= 5;
            }
            else if (prbPee.Value == 0 && prbHappiness.Value == 0 && prbHealth.Value == 0)
            {
                prbHealth.Value -= 0;
            }

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
            //if (prbHappiness.Value == 0)
            //{
            //    prbHealth.Value -= 5;
            //}
            //else if (prbHealth.Value == 0) 
            //{
            //    prbHealth.Value -= 0;
            //}

        }
    }
}
