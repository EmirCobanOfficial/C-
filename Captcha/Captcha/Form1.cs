using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rsg = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "12345" && textBox3.Text == label1.Text)
            {
                Form2 fr2 = new Form2();
                fr2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Doğru Yazınız");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string character1;
            string[] series1 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z", "W", "X" };
            int symbol = rsg.Next(0, series1.Length);
            character1 = (series1[symbol]);
            label1.Text = character1.ToString();

            string character2;
            string[] series2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            int symbol2 = rsg.Next(0, series2.Length);
            character2 = (series2[symbol2]);

            string character3;
            string[] series3 = { "!", "#", "+", "-", "*", "|", ">", "<", "?" };
            int symbol3 = rsg.Next(0, series3.Length);
            character3 = (series3[symbol3]);

            string character4;
            string[] series4 = { "a", "b", "c", "d", "e", "f", "g", "ı", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z", "w", "x" };
            int symbol4 = rsg.Next(0, series4.Length);
            character4 = (series4[symbol4]);

            string character5;
            string[] series5 = { "a", "B", "1", "2", "0", "*", "#", "+", "-", "H", "M", "m", "d", "u", "!" };
            int symbol5 = rsg.Next(0, series5.Length);
            character5 = (series5[symbol5]);

            label1.Text = character1 + character2 + character3 + character4 + character5;
        }
    }
}
