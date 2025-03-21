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
namespace DisplayMember_ve_ValueMember
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=EMIRMONSTER\\SQLEXPRESS;Initial Catalog=test99;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute Liste2", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //verileri listeleme
            listele();

            //ürünler çekmek.
            SqlCommand komut = new SqlCommand("select * from ürünler", baglan);
            SqlDataAdapter rd = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            rd.Fill(dt);
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "URUNAD";
            comboBox1.DataSource = dt;

            //müsterileri çekmek
            SqlCommand komut2 = new SqlCommand("select * from müsteriler", baglan);
            SqlDataAdapter rd2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            rd2.Fill(dt2);
            comboBox2.ValueMember = "ID";
            comboBox2.DisplayMember = "AD";
            comboBox2.DataSource = dt2;
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into FIRMAHAREKETLER (URUNID,ADET,FIRMA,FIYAT) values (@p1,@p2,@p3,@p4)",baglan);
            komut.Parameters.AddWithValue("@p1", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            komut.Parameters.AddWithValue("@p3", comboBox2.SelectedValue);
            komut.Parameters.AddWithValue("@p4", textBox2.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Ürünler Bşarıyla tabloya eklenmiştir");
        }
    }
}