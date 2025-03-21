namespace Faktoryel_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 1;
        int faktoryel = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 7; i++)
            {
                faktoryel = faktoryel * i;
                listBox1.Items.Add(faktoryel);
                label1.Text = faktoryel.ToString();
            }
        }
    }
}
