using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Datagridview_Kütüphane_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=EMIRMONSTER\\SQLEXPRESS;Initial Catalog=Kütüphane;Integrated Security=True;");


        public void verilerigsöter(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler,baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigsöter("Select * From Kıtaplar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into Kıtaplar (ad,yazar,sayfano,basımevi,tür) values (@adi,@yazari,@sayfanosu,@basımyeri,@turu)", baglan);
            komut.Parameters.AddWithValue("@adi", textBox1.Text);
            komut.Parameters.AddWithValue("@yazari", textBox2.Text);
            komut.Parameters.AddWithValue("@sayfanosu", textBox3.Text);
            komut.Parameters.AddWithValue("@basımyeri", textBox4.Text);
            komut.Parameters.AddWithValue("@turu", textBox5.Text);
            komut.ExecuteNonQuery();
            verilerigsöter("Select * from Kıtaplar");
            baglan.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from Kıtaplar where ad=@adi",baglan);
            komut.Parameters.AddWithValue("@adi", textBox6.Text);
            komut.ExecuteNonQuery();
            verilerigsöter("Select * From Kıtaplar");
            baglan.Close();

            textBox6.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from Kıtaplar where ad like '%" + textBox7.Text + "%'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilialan=dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            string yazar = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            string sayfano = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            string basımevi = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            string tur = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();

            textBox1.Text = ad;
            textBox2.Text = yazar;
            textBox3.Text = sayfano;
            textBox4.Text = basımevi;
            textBox5.Text = tur;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update Kıtaplar set yazar='" + textBox2.Text + "',sayfano='" + textBox3.Text + "',basımevi='" + textBox4.Text + "',tür='" + textBox5.Text + "' where ad='" + textBox1.Text + "'", baglan);
            komut.ExecuteNonQuery();
            verilerigsöter("Select * from Kıtaplar");
            baglan.Close();

        }
    }
}
