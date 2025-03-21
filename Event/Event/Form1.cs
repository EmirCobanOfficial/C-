using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text=="sarı")
            {
                this.BackColor = Color.Yellow;
            }
            if (textBox1.Text == "mavi")
            {
                this.BackColor = Color.CadetBlue;
            }
            if (textBox1.Text == "pembe")
            {
                this.BackColor = Color.LightPink;
            }
            int kalan = Convert.ToInt16(label2.Text);
            kalan--;
            label2.Text = kalan.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
