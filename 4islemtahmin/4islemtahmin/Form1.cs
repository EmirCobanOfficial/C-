using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4islemtahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int puan = 0;
        int süre = 30;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            textBox1.Clear();

            int sayı1, sayı2, islem;
            int a, b;
            int toplam, carp, cıkar, bol;

            sayı1 = rastgele.Next(0, 51);
            sayı2 = rastgele.Next(0, 51);
            islem = rastgele.Next(1, 5);

            label1.Text = sayı1.ToString();
            label3.Text = sayı2.ToString();

            a=Convert.ToInt32(label1.Text);
            b=Convert.ToInt32(label3.Text);

            if (islem == 1)
            {
                label2.Text = "+";
                toplam = a + b;
                label5.Text = toplam.ToString();
            }
            if (islem == 2)
            {
                label2.Text = "-";
                cıkar = a - b;
                label5.Text = cıkar.ToString();

                if (islem == 3)
                {
                    label2.Text = "*";
                    carp = a * b;
                    label5.Text = carp.ToString();
                }
                if (islem == 4)
                {
                    label2.Text = "/";
                    bol = a / b;
                    label5.Text = bol.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;

            if (label5.Text == textBox1.Text)
            {
                label6.Text = "Tebrikler";
                puan = puan + 10;
                label6.Text = puan.ToString();
            }
            else
            {
                puan = puan - 10;
                label6.Text = puan.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            label8.Text = süre.ToString();

            if (süre ==0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                timer1.Stop();
                süre = 30;
                button3.Visible = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            timer1.Start();
            süre = 30;
            button3.Visible = false;
            puan = 0;
            label6.Text = puan.ToString();
            label1.Text = "0";
            label3.Text = "0";
            textBox1.Clear();
        }
    }
}
