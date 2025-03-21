using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using araskargoo.SuratKargoApp;

namespace araskargoo
{
    public partial class Form1 : Form
    {
        private bool kullaniciDogrulandi = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSendRequest_Click_1(object sender, EventArgs e)
        {
            try
            {
                var client = new SuratKargoApp.servicesSoapClient();

                string kullaniciAdi = txtKullaniciAdi.Text;
                string sifre = txtSifre.Text;

                var gonderiModel = new GonderiModel
                {
                    KisiKurum = txtKisiKurum.Text,
                    SahisBirim = txtSahisBirim.Text,
                    AliciAdresi = txtAdres.Text,
                    Il = cmbIl.SelectedItem.ToString(),
                    Ilce = cmbIlce.SelectedItem.ToString(),
                    TelefonEv = txtTelefonEv.Text,
                    TelefonIs = txtTelefonIs.Text,
                    TelefonCep = txtTelefonCep.Text,
                    Email = txtEmail.Text,
                    AliciKodu = txtAliciKodu.Text,
                    KargoTuru = Convert.ToInt32(cmbKargoTuru.SelectedItem),
                    OdemeTipi = Convert.ToInt32(cmbOdemeTipi.SelectedItem),
                    Adet = Convert.ToInt32(txtAdet.Text),
                    BirimDesi = txtDesi.Text,
                    BirimKg = txtKg.Text,
                    KargoIcerigi = txtKargoIcerigi.Text,
                    IrsaliyeSeriNo = txtIrsaliyeSeriNo.Text,
                    IrsaliyeSiraNo = txtIrsaliyeSiraNo.Text,
                    KapidanOdemeTahsilatTipi = Convert.ToInt32(cmbKapidanOdeme.SelectedItem),
                    KapidanOdemeTutari = txtKapidanOdemeTutari.Text,
                    EkHizmetler = txtEkHizmetler.Text,
                    TasimaSekli = Convert.ToInt32(cmbTasimaSekli.SelectedItem),
                    TeslimSekli = Convert.ToInt32(cmbTeslimSekli.SelectedItem),
                    SevkAdresi = txtSevkAdresi.Text,
                    GonderiSekli = Convert.ToInt32(cmbGonderiSekli.SelectedItem),
                    TeslimSubeKodu = txtTeslimSubeKodu.Text,
                    Pazaryerimi = Convert.ToInt32(cmbPazaryeri.SelectedItem),
                    EntegrasyonFirmasi = txtEntegrasyonFirmasi.Text,
                    Iademi = chkIademi.Checked
                };

                var response = client.GonderiyiKargoyaGonderYeniSiparisBarkodOlustur(kullaniciAdi, sifre, gonderiModel);

                if (!response.isError)
                {
                    MessageBox.Show("Barkod: " + response.Barcode);
                }
                else
                {
                    MessageBox.Show("Hata: " + response.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}