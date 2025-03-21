using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Enum_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Sehirler 
        { 
        x,Adana,Adıyaman,Ağrı,Amasya,Ankara,Antalya,Artvin,Aydın
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int plaka =Convert.ToInt16(textBox1.Text);
            Sehirler s;
            s=(Sehirler)plaka;
            label2.Text =s.ToString();
        }
    }
}
