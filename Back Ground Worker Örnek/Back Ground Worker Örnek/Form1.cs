﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Back_Ground_Worker_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;    
        }

        long toplam = 0;
        private void dongu()
        {
            for (int i = 0; i <= 100000; i++)
            {
                toplam = toplam + i;
                this.Text = i.ToString();
            }
            MessageBox.Show(toplam.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            dongu();
        }
    }
}
