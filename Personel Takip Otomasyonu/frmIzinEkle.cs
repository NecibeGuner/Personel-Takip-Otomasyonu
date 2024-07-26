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

namespace Personel_Takip_Otomasyonu
{
    public partial class frmIzinEkle : Form
    {
        public frmIzinEkle()
        {
            InitializeComponent();
        }
        Izin Izin = new Izin();
        Label lbl = new Label();

        private void comboPersonelAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            YapilanZamlar.ComboSecilirsePersonenelIDGetir(comboPersonelAdSoyad, lbl);
        }

        private void frmIzinEkle_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaKayitGetir(comboBoxIzinTurleri);
            Izin.ComboyaPersonelGetir(comboPersonelAdSoyad);
        }
        private void Temizle()
        {
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
            

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Izin i = new Izin();
            i.PERSONELID = int.Parse(lbl.Text);
            i.KullaniciID = Kullanicilar.kid;
            i.IzinTurID = (int)comboBoxIzinTurleri.SelectedValue;
            i.IzinBaslangic = dateTimeBaslangic.Value;
            i.IzinBitis = dateTimeBitis.Value;
            i.Islem = i.PERSONELID + "  için " + comboBoxIzinTurleri.Text + " oluşturuldu.";
            i.Aciklama = txtAciklama.Text;
            i.Tarih = DateTime.Now;
            i.Saat = DateTime.Now;

            string sql = "insert into IzinHareketleri (PERSONELID, KullaniciID, IzinTurID, IzinBaslangic, IzinBitis, Islem, Aciklama, Tarih, Saat) " +
                         "values (@PERSONELID, @KullaniciID, @IzinTurID, @izinBaslangic, @izinBitis, @Islem, @Aciklama, @Tarih, @Saat)";

            using (SqlCommand komut = new SqlCommand(sql, Veritabani.connection))
            {
                komut.Parameters.AddWithValue("@PERSONELID", i.PERSONELID);
                komut.Parameters.AddWithValue("@KullaniciID", i.KullaniciID);
                komut.Parameters.AddWithValue("@IzinTurID", i.IzinTurID);
                komut.Parameters.AddWithValue("@izinBaslangic", i.IzinBaslangic);
                komut.Parameters.AddWithValue("@izinBitis", i.IzinBitis);
                komut.Parameters.AddWithValue("@Islem", i.Islem);
                komut.Parameters.AddWithValue("@Aciklama", i.Aciklama);
                komut.Parameters.AddWithValue("@Tarih", i.Tarih);
                komut.Parameters.AddWithValue("@Saat", i.Saat);

                try
                {
                    Veritabani.connection.Open();
                    komut.ExecuteNonQuery();
                    Temizle();
                    MessageBox.Show("İzin kayıt oluşturuldu.", "izin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Uyarı");
                }
             }  
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}