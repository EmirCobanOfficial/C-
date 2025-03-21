namespace AlarmÖrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute.ToString();

            if (comboBox2.Text == label2.Text)
            {
                timer1.Stop();
                MessageBox.Show ("UYANMA ZAMANI");
                axWindowsMediaPlayer1.URL = "C:\\Users\\Emir Çoban\\Desktop\\spor müzikleri ve fotoları\\alarm.mp3";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }

            for (int j = 0; j < 60; j++)
            {
                comboBox2.Items.Add(j);
            }
        }
    }
}
