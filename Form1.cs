namespace wf311
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Привет, " + textBox1.Text;
            pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "Прощай, " + textBox1.Text;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

        }
    }
}
