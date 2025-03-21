using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Application_StartupPath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=EMIRMONSTER\\SQLEXPRESS;Initial Catalog=kisiler;Integrated Security=True");
        private void dataview()
        {
            listView1.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from person", connection);
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem add = new ListViewItem(read["Ad"].ToString());
                    add.SubItems.Add(read["Soyad"].ToString());
                    add.SubItems.Add(read["Sehir"].ToString());
                    add.SubItems.Add(read["Yas"].ToString());
                    add.SubItems.Add(read["Meslek"].ToString());
                    listView1.Items.Add(add);
                }
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataview();
        }
        private void savedata()
        {
            using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into person (Ad,Soyad,Sehir,Yas,Meslek) values (@Ad,@Soyad,@Sehir,@Yas,@Meslek)", connection);
                cmd.Parameters.AddWithValue("@Ad", textBox1.Text);
                cmd.Parameters.AddWithValue("@Soyad", textBox1.Text);
                cmd.Parameters.AddWithValue("@Sehir", textBox1.Text);
                cmd.Parameters.AddWithValue("@Yas", textBox1.Text);
                cmd.Parameters.AddWithValue("@Meslek", textBox1.Text);
                cmd.ExecuteNonQuery();
            }
            connection.Close();
            dataview();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            savedata();
        }
    }
}