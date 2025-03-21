using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analog_Saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer t = new Timer();
        int genislik = 300, yukseklik = 300, saniyeibre = 140, dakikaibre = 110, saatibre = 80;
        int ortaX, ortaY;
        Bitmap bmp;
        Graphics g;

        private void timer1_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bmp);
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            int[] ibrekoordinat = new int[2];
            g.Clear(Color.White);
            g.DrawEllipse(new Pen(Color.Black, 1F), 0, 0, yukseklik, genislik);

            g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
            g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
            g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
            g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

            ibrekoordinat = mscoord(ss, saniyeibre);
            g.DrawLine(new Pen(Color.Red,1F), new Point(ortaX,ortaY), new Point(ibrekoordinat[0], ibrekoordinat[1]));

            // dakika için
            ibrekoordinat = mscoord(mm, dakikaibre);
            g.DrawLine(new Pen(Color.Orange, 2F), new Point(ortaX, ortaY), new Point(ibrekoordinat[0], ibrekoordinat[1]));

            ibrekoordinat = hrcoord(hh % 12, mm, saatibre);
            g.DrawLine(new Pen(Color.ForestGreen, 3F), new Point(ortaX, ortaY), new Point(ibrekoordinat[0], ibrekoordinat[1]));

            pictureBox1.Image = bmp;

            this.Text = "Saat: " + hh + ":" + mm + ":" + ss;
            g.Dispose();
        }
        private int[] mscoord(int saniyedeger, int saataci)
        {
            int[] coord = new int[2];
            saniyedeger *= 6;
            if (saniyedeger >= 0 && saniyedeger <= 180)
            {
                coord[0] = ortaX + (int)(saataci * Math.Sin(Math.PI * saniyedeger / 180));
                coord[1] = ortaY - (int)(saataci * Math.Cos(Math.PI * saniyedeger / 180));
            }
            else
            {
                coord[0] = ortaX - (int)(saataci * -Math.Sin(Math.PI * saniyedeger / 180));
                coord[1] = ortaY - (int)(saataci * Math.Cos(Math.PI * saniyedeger / 180));
            }
            return coord;
        }
        int[] coord = new int[2];
        private int[] hrcoord(int saatdeger, int dakikadeger, int saataci)
        {
            int val = (int)((saatdeger * 30) + (dakikadeger * 0.5));
            if (val >= 0 && val <= 180)
            {
                coord[0] = ortaX + (int)(saataci * Math.Sin(Math.PI * val / 180));
                coord[1] = ortaY - (int)(saataci * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = ortaX - (int)(saataci * -Math.Sin(Math.PI * val / 180));
                coord[1] = ortaX - (int)(saataci * -Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(genislik+1, yukseklik+1);
            ortaX = genislik / 2;
            ortaY = yukseklik / 2;
            this.BackColor = Color.White;
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }
    }
}
