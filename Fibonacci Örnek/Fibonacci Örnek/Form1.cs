namespace Fibonacci_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1 = 1;
            int sayı2 = 2;
            int sayı3;

            listBox1.Items.Add(sayı1);
            listBox1.Items.Add(sayı2);

            for (int i = 1; i <= 8; i++)
            {
                sayı3 = sayı1 + sayı2;

                sayı1 = sayı2;
                sayı2 = sayı3;

                listBox1.Items.Add(sayı3);
            }
        }
    }
}
