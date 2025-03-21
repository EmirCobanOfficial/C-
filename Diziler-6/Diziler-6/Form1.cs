using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayılar = { 11, 12, 25, 36, 48, 66, 154, -25,-27,-39,-41 };
            foreach (int sayı in sayılar)
            {
                if (sayı %3 ==0 && sayı < 0)
                {
                    listBox1.Items.Add(sayı);
                }

            }

        }
    }
}
