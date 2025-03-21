using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritma_Örnek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam = 0;

        private void button1_Click(object sender, EventArgs e)

        {
            int bolunensayısı = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 7 ==0)
                {
                    bolunensayısı++;
                    bolunensayı.Text = bolunensayısı.ToString();
                    toplam = toplam + i;
                    bolunentoplam.Text = toplam.ToString();
                }
            }
        }
    }
}
 