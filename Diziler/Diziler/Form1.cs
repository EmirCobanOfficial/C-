using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isim = new string[10];
        string[] ilce = new string[10];
        string[] telefon = new string[10];
        int i = 0;

        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isim[i] = textBox1.Text;
            ilce[i] = textBox2.Text;
            telefon[i] = textBox3.Text;
            i++;
            temizle();
        }

        private void btn_görüntüle_Click(object sender, EventArgs e)
        {
            i--;
            lblisim.Text = isim[i];
            lblilce.Text = ilce[i];
            lbltelefon.Text = telefon[i];

        }

        private void btn_önceki_Click(object sender, EventArgs e)
        {
            i--;
            lblisim.Text = isim[i];
            lblilce.Text= ilce[i];
            lbltelefon.Text = telefon[i];

        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            i++;
            lblisim.Text = isim[i];
            lblilce.Text = ilce[i];
            lbltelefon.Text = telefon[i];
        }
    }
}
