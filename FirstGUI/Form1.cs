namespace FirstGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            pictureBoxWaltonLogo.Image = Image.FromFile("E:\\walton.jpg");
            pictureBoxBarcode.Image = Image.FromFile("E:\\qr.jpg");
            pictureBoxBarcode.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelTableRow1_Click(object sender, EventArgs e)
        {

        }
    }
}