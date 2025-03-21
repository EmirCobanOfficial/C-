using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter da;
        DataTable tablo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=EMIRMONSTER\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Kitaplar", baglanti);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}