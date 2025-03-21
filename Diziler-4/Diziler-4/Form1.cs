using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] sayılar = { 1.25, 3.45, 8.75, 4.16, 8.21,7.65,8.71};
            int eleman = sayılar.Length;
            label1.Text = eleman.ToString();
        }
    }
}
