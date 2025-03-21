using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayılar = { 6, 7, 8 };
            int toplam = 0;

            for (int i = 0; i < sayılar.Length; i++)
            {
                toplam = toplam + sayılar[i];
                label1.Text = toplam.ToString();
            }
        }
    }
}
