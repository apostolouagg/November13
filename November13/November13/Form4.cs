using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace November13
{
    public partial class Form4 : Form
    {
        bool labels;

        public Form4(int score)
        {
            InitializeComponent();
            label2.Text = score.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labels)
            {
                label3.Show();
                label4.Hide();
                labels = false;
            }
            else
            {
                label4.Show();
                label3.Hide();
                labels = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            label5.Hide();
            panel1.Hide();

            button1.Show();
            textBox1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label5.Show();
            panel1.Show();

            button1.Hide();
            textBox1.Hide();
            textBox1.Text = "there was a link here at some point. If u are reading this instead of a link then you are not that special someone";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Show();
            panel1.Show();

            button1.Hide();
            textBox1.Hide();
        }
    }
}
