using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace November13
{
    public partial class Form2 : Form
    {
        Random random;
        Label mylabel = new Label();

        int score = 0;
        int time = 35;
        public int results;

        bool restart;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
            this.BackgroundImage = Properties.Resources.Screenshot_2;

            button1.Hide();

            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();

            label6.Text = score.ToString();
            label7.Text = time.ToString();

            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            button3.Show();

            pictureBox1.Show();
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            pictureBox1.Hide();
            button3.Hide();

            mylabel.Text = "Click the raccoon to start playing again.";
            mylabel.Location = new System.Drawing.Point(450, 310);
            mylabel.Size = new System.Drawing.Size(412, 28);
            mylabel.ForeColor = System.Drawing.Color.Black;
            mylabel.BackColor = System.Drawing.Color.Transparent;
            mylabel.Font = new Font("MS Reference Sans Serif", 12, FontStyle.Bold);
            this.Controls.Add(mylabel);
            mylabel.Hide();

            random = new Random();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score++;
            label6.Text = score.ToString();

            pictureBox1.Image = Properties.Resources.explosion;

            if (restart)
            {
                timer1.Enabled = true;
                mylabel.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.racoon_4;

            int x1, y1;
            x1 = random.Next(pictureBox1.Width, this.Width - pictureBox1.Width);
            y1 = random.Next(25, this.Height - pictureBox1.Height - 80);
            pictureBox1.Location = new Point(x1, y1);

            time--;
            label7.Text = time.ToString();

            if (time == 0)
            {
                timer1.Enabled = false;
                pictureBox1.Enabled = false;

                if (int.Parse(label6.Text) < 20)
                {
                    Form3 form3 = new Form3(score);
                    form3.Show();
                }
                else
                {
                    Form4 form4 = new Form4(score);
                    form4.Show();
                }

                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            restart = true;

            mylabel.Show();

            score = 0;
            label6.Text = score.ToString();

            timer1.Enabled = false;
            time = 30;
            label7.Text = time.ToString();
        }
    }
}
