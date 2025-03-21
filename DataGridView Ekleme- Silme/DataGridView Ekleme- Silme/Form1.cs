﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataGridView_Ekleme__Silme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=EMIRMONSTER\\SQLEXPRESS;Initial Catalog=Kütüphane;Integrated Security=True;");

        public void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler,baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigöster("Select * From Kıtaplar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into Kıtaplar (ad,yazar,sayfano,basımevi,tür) values (@adi,@yazari,@sayfanosu,@basımyeri,@turu)", baglan);
            komut.Parameters.AddWithValue("@adi", textBox1.Text);
            komut.Parameters.AddWithValue("@yazari", textBox2.Text);
            komut.Parameters.AddWithValue("@sayfanosu", textBox3.Text);
            komut.Parameters.AddWithValue("@basımyeri", textBox4.Text);
            komut.Parameters.AddWithValue("@turu", comboBox1.Text); 
            komut.ExecuteNonQuery();
            verilerigöster("Select * From Kıtaplar");
            baglan.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from  Kıtaplar where ad=@adi", baglan);
            komut.Parameters.AddWithValue("@adi", textBox5.Text);
            komut.ExecuteNonQuery();
            verilerigöster("Select * From Kıtaplar");
            baglan.Close();
            textBox5.Clear();
        }
    }
}
