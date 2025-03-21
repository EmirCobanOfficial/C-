using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate int islemler(int p1, int p2);
             

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam(int s1,int s2)
            {
                int sonuc = s1 + s2;
                return sonuc;
            }

            int fark(int a1, int a2)
            {
                int sonuc1 = a1 - a2;
                return sonuc1;
            }

            int carp(int y1, int y2)
            {
                int sonuc2 = y1 * y2;
                return sonuc2;
            }

            int bol(int h1, int h2)
            {
                int bolsonuc = h1 / h2;
                return bolsonuc;
            }

            listBox1.Items.Add(bol(8,2));
            listBox1.Items.Add(carp(80, 5));
            listBox1.Items.Add(fark(850, 600));
            listBox1.Items.Add(toplam(8, 9));
        }
    }
}
