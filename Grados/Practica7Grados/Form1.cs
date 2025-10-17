namespace Practica7Grados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, farh1;
            v1 = double.Parse(textBox1.Text);
            farh1 = v1 * (9.0 / 5.0) + 32;
            label3.Text = farh1.ToString();
            label4.Text = "Fahrenheit";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, cent1;
            v1 = double.Parse(textBox1.Text);
            cent1 = (v1 - 32) * (5.0 / 9.0);
            label3.Text = cent1.ToString();
            label4.Text = "Centigrados";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            label3.Text = " ";
            label4.Text = " ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
