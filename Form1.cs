using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
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
            if (textBox1.Text == "" && textBox2.Text == "")
                MessageBox.Show("Error");
            else if (textBox1.Text == "admin" && textBox2.Text == "321")
            {
                Form2 win = new Form2();
                win.Show();
            }
            else if (textBox1.Text == "user" && textBox2.Text == "123")
            {
                Form3 wind = new Form3();
                wind.Show();
            }
            else MessageBox.Show("Error");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
