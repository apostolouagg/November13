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
    public partial class Form3 : Form
    {
        bool labels;

        public Form3(int score)
        {
            InitializeComponent();
            label4.Text = score.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labels)
            {
                label1.Show();
                label2.Hide();
                labels = false;
            }
            else
            {
                label2.Show();
                label1.Hide();
                labels = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
