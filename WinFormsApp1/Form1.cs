using System.Resources;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            pikachu pikachu = new pikachu();
            LabelName.Text = pikachu.Name();
            //add resource file
            pictureBox1.Image = WinFormsApp1.Properties.Resources.pikachu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Magikarp magikarp = new Magikarp();
            LabelName.Text = magikarp.Name();
            pictureBox1.Image = WinFormsApp1.Properties.Resources.Magikarp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadTogepi_Click(object sender, EventArgs e)
        {
            Togepi togepi = new Togepi();
            LabelName.Text = togepi.Name();
            pictureBox1.Image = WinFormsApp1.Properties.Resources.togepi;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GougingFire GougingFire = new GougingFire();
            LabelMonster.Text = GougingFire.Name();
            pictureBox2.Image = WinFormsApp1.Properties.Resources.GougingFire;
        }

        private void Eevee_Click(object sender, EventArgs e)
        {
            Eevee Eevee = new Eevee();
            LabelName.Text = Eevee.Name();
            pictureBox1.Image = WinFormsApp1.Properties.Resources.Eevee1;
        }

        private void loadFletchling_Click(object sender, EventArgs e)
        {
            Fletchling Fletchling = new Fletchling();
            LabelName.Text = Fletchling.Name();
            pictureBox1.Image = WinFormsApp1.Properties.Resources.Fletchling;
        }

        private void loadCastform_Click(object sender, EventArgs e)
        {
            Castform Castform = new Castform();
            LabelName.Text = Castform.Name();
            pictureBox1.Image = WinFormsApp1.Properties.Resources.Castform;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
