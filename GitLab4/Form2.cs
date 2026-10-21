using System;
using System.Windows.Forms;

namespace GitLab4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a) &&
                double.TryParse(textBox2.Text, out double b))
                label2.Text = "Сумма: " + (a + b);
            else
                label2.Text = "Введите числа";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}