namespace At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık;
        int ikinciatsolauzaklık;
        int ucuncuatsolauzaklık;

        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();

            int birinciatgenisligi = pictureBox1.Width;
            int ikinciatgenisligi = pictureBox2.Width;
            int ucuncuatgenisligi = pictureBox3.Width;

            int bitisuzaklıgı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if (birinciatgenisligi > ikinciatgenisligi + 5 && birinciatgenisligi > ucuncuatgenisligi + 5)
            {
                label6.Text = "1 Numaralı At Yarışı Önde Götürüyor";
            }

            if (ikinciatgenisligi > birinciatgenisligi +5 && ikinciatgenisligi > ucuncuatgenisligi +5)
            {
                label6.Text = "2 Numaralı At Yarışı Önde Götürüyor";
            }

            if (ucuncuatgenisligi > birinciatgenisligi +5 && ucuncuatgenisligi > ikinciatgenisligi +5)
            {
                label6.Text = "2 Numaralı At Yarışı Önde Götürüyor";
            }

            if (birinciatgenisligi + pictureBox1.Left >=bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text="1. At yarışı kazandı";
            }
            if (birinciatgenisligi + pictureBox2.Left >= bitisuzaklıgı)
            {
                timer1.Stop();
                label6.Text = "2. At yarışı kazandı";
            }
            if (ucuncuatgenisligi + pictureBox3.Left >= bitisuzaklıgı)
            {
                timer1.Stop();
                label6.Text = "3. At yarışı kazandı";
            }
        }
    }
}