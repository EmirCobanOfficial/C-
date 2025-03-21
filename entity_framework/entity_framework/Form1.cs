using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entity_framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        personel2Entities ent = new personel2Entities();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ent.tbl_personel.ToList();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            tbl_personel tbl = new tbl_personel();
            tbl.PerAd = txtad.Text;
            tbl.PerSoyad = txt_soyad.Text;
            tbl.PerSehir = txt_sehir.Text;
            tbl.PerMaas = Convert.ToInt16(txt_maas.Text);
            ent.tbl_personel.Add(tbl);
            ent.SaveChanges();
            MessageBox.Show("Personel Sisteme kaydedildi");
            dataGridView1.DataSource = ent.tbl_personel.ToList();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtıd.Text);

            tbl_personel tbl = ent.tbl_personel.First(f => f.Periid == id);
            ent.tbl_personel.Remove(tbl);
            ent.SaveChanges();
            MessageBox.Show("Personel Sistemden silindi");
            dataGridView1.DataSource = ent.tbl_personel.ToList();
        }
        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtıd.Text);
            tbl_personel tbl = ent.tbl_personel.First(f => f.Periid == id);
            tbl.PerAd = txtad.Text;
            tbl.PerSoyad = txt_soyad.Text;
            tbl.PerSoyad = txt_soyad.Text;
            ent.SaveChanges();
            MessageBox.Show("Personel Bilgisi Güncellendi");
            dataGridView1.DataSource = ent.tbl_personel.ToList();
        } 
    }
}