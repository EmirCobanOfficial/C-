using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aşırı_Yükleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int toplama(int sayı1, int sayı2)
        {
            int sonuc = sayı1 + sayı2;
            return sonuc;
        }

        int toplama(int sayı1, int sayı2,int sayı3)
        {
            int sonuc = sayı1 + sayı2 + sayı3;
            return sonuc;
        }
        int toplama(int sayı1, int sayı2, int sayı3, int sayı4)
        {
            int sonuc = sayı1 + sayı2 + sayı3 + sayı4;
            return sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(toplama(5, 7));
            listBox1.Items.Add(toplama(4, 5, 6, 7));
        }
    }
}
