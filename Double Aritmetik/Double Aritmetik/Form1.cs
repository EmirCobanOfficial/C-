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
            double sayý1, sayý2;
            double fark, bölüm, toplam, çarpým;

            sayý1 = Convert.ToDouble(textBox1.Text);
            sayý2 = Convert.ToDouble(textBox2.Text);

            toplam = sayý1 + sayý2;
            fark = sayý1 - sayý2;
            bölüm = sayý1 / sayý2;
            çarpým = sayý1 * sayý2;

            lbltoplamý.Text = Convert.ToString(toplam);
            lblfarký.Text = Convert.ToString(fark);
            lblbölümü.Text=Convert.ToString(bölüm);
            lblcarpýmý.Text=Convert.ToString(çarpým);

        }
    }
}
