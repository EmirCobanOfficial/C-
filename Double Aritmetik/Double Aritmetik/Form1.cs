namespace Double_Aritmetik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double say�1, say�2;
            double fark, b�l�m, toplam, �arp�m;

            say�1 = Convert.ToDouble(textBox1.Text);
            say�2 = Convert.ToDouble(textBox2.Text);

            toplam = say�1 + say�2;
            fark = say�1 - say�2;
            b�l�m = say�1 / say�2;
            �arp�m = say�1 * say�2;

            lbltoplam�.Text = Convert.ToString(toplam);
            lblfark�.Text = Convert.ToString(fark);
            lblb�l�m�.Text=Convert.ToString(b�l�m);
            lblcarp�m�.Text=Convert.ToString(�arp�m);

        }
    }
}
