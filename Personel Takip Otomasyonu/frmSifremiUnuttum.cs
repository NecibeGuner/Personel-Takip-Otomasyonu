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
    public partial class frmSifremiUnuttum : Form
    {
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            comboBoxSoru.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = int.Parse(txtKullaniciID.Text);
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.AdiSoyadi = txtAdSoyad.Text;
            k.Soru = comboBoxSoru.Text;
            k.Cevap = txtCevap.Text;
            k.Aciklama = txtAciklama.Text;
            k.Tarih = DateTime.Now;
            if (Kullanicilar.SoruCevapDogrula(k.KullaniciID, k.Soru, k.Cevap))
            {
                if (txtSifre.Text == TxtSifreTekrar.Text)
                {
                    string sql = "UPDATE kullanicilar SET kullaniciAdi = @KullaniciAdi, Sifre = @Sifre, AdiSoyadi = @AdiSoyadi, " +
                                 "Soru = @Soru, Cevap = @Cevap, Tarih = @Tarih, Aciklama = @Aciklama WHERE KullaniciID = @KullaniciID";
                    SqlCommand komut = new SqlCommand(sql, Veritabani.connection);
                    komut.Parameters.AddWithValue("@KullaniciAdi", k.KullaniciAdi);
                    komut.Parameters.AddWithValue("@Sifre", k.Sifre);
                    komut.Parameters.AddWithValue("@AdiSoyadi", k.AdiSoyadi);
                    komut.Parameters.AddWithValue("@Soru", k.Soru);
                    komut.Parameters.AddWithValue("@Cevap", k.Cevap);
                    komut.Parameters.AddWithValue("@Tarih", k.Tarih);
                    komut.Parameters.AddWithValue("@Aciklama", k.Aciklama);
                    komut.Parameters.AddWithValue("@KullaniciID", k.KullaniciID);

                    Veritabani.connection.Open();
                    komut.ExecuteNonQuery();
                    Veritabani.connection.Close();

                    MessageBox.Show("Kullanıcı bilgileri güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor, tekrardan deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Güvenlik sorusu veya cevabı yanlış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
