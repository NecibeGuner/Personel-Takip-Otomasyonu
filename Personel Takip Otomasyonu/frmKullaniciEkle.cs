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
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            
        }
        void Temizle()
        {
            comboSoru.Text = "";
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
            
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.AdiSoyadi = txtAdiSoyadi.Text;
            k.Soru = comboSoru.Text;
            k.Cevap = txtCevap.Text;
            k.Aciklama = txtAciklama.Text;
            k.Tarih = DateTime.Now;
            k.Rol = comboRol.Text;

            if (txtSifre.Text == txtSifreTekrardan.Text)
            {
                string sql = "insert into Kullanicilar(KullaniciAdi,Sifre,AdiSoyadi,Soru,Cevap,Tarih," +
                    "Aciklama,Rol) values('" + k.KullaniciAdi + "','" + k.Sifre + "','" + k.AdiSoyadi + "'," +
                    "'" + k.Soru + "','" + k.Cevap + "',@Tarih,'" + k.Aciklama + "','" + k.Rol + "')";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = k.Tarih;
                MessageBox.Show("Yeni kullanıcı eklendi.", "Kayıt", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                Veritabani.ESG(komut, sql);
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor, tekrardan deneyiniz", "Uyarı", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
