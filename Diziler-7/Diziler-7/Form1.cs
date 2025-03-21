using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayaç;
        string[] isimler = new string[5];
        private void button1_Click(object sender, EventArgs e)
        {
            isimler[sayaç] = textBox1.Text;
            sayaç++;

            if (sayaç ==5)
                sayaç = 0;
            label1.Text = (sayaç + 1) + ".ismi girin";
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                listBox1.Items.Add(isimler[i]);
            }
        }
    }
}
