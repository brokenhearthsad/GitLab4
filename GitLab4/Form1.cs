using System;
using System.Windows.Forms;

namespace GitLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Главное окно";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();
            this.Hide();
        }
    }
}
