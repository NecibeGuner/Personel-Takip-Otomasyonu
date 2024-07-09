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

            if (txtSifre.Text == TxtSifreTekrar.Text)
            {
                string sql = "update kullanicilar set kullaniciAdi='" + k.KullaniciAdi + "',Sifre='" + k.Sifre + "',AdiSoyadi='" + k.AdiSoyadi + "'," +
                 "Soru='" + k.Soru + "',Cevap='" + k.Cevap + "',Tarih=@Tarih,Aciklama='" + k.Aciklama + "' where kullaniciID='" + k.KullaniciID + "'";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = k.Tarih;
                MessageBox.Show("Kullanıcı bilgileri güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                Veritabani.ESG(komut, sql);
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor, tekrardan deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
