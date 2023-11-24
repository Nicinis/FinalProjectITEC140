using System.Runtime.Versioning;

namespace FinalProjectITEC140
{
    public partial class Form1 : Form
    {
        Bitmap Neutral = new Bitmap("../../../resources/NeutralPikachu.jpg");
        public Form1()
        {
            InitializeComponent();
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
    }
}
