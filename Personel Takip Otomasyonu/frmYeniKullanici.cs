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
    public partial class frmYeniKullanici : Form
    {
        public frmYeniKullanici()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.AdiSoyadi = txtAdSoyad.Text;
            k.Soru = comboBoxSoru.Text;
            k.Cevap = txtCevap.Text;
            k.Aciklama = txtAciklama.Text;
            k.Tarih = DateTime.Now;

            if (txtSifre.Text==TxtSifreTekrar.Text)
            {
                string sql = "insert into Kullanicilar(KullaniciAdi,Sifre,AdiSoyadi,Soru,Cevap,Tarih,Aciklama) values('" + k.KullaniciAdi + "'," +
                    "'" + k.Sifre + "','" + k.AdiSoyadi + "','" + k.Soru + "','" + k.Cevap + "',@Tarih,'" + k.Aciklama + "')";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = k.Tarih;
                MessageBox.Show("Yeni kullanıcı eklendi. Kullanıcı ID : ", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                Veritabani.ESG(komut, sql);

                //try
                //{
                //    Veritabani.connection.Open();
                //    int insertedId = (int)komut.ExecuteScalar(); // ExecuteScalar metodu ile yeni eklenen kaydın ID'si alınır.
                //    Veritabani.connection.Close();

                //    MessageBox.Show("Yeni kullanıcı eklendi. Kullanıcı ID : " + insertedId, "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    Temizle();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor, tekrardan deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
