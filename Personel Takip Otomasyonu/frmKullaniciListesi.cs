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
    public partial class frmKullaniciListesi : Form
    {
        public frmKullaniciListesi()
        {
            InitializeComponent();
        }

        private void YenileListele()
        {
            Veritabani.Listele_Ara(dataGridView1, "select k.KullaniciID,k.KullaniciAdi,k.AdiSoyadi," +
               "k.Tarih,k.Aciklama from Kullanicilar k");
            lblToplamKayit.Text = "Taplam Kayıt: " + (dataGridView1.RowCount - 1) + " kayıt listelenmiştir...";         
        }

        private void frmKullaniciListesi_Load(object sender, EventArgs e)
        {
            YenileListele();
        }
        
        void Temizle()
        {
            dateTimePickerGirisTarihi.Value = DateTime.Now;
            //comboDepartman.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = int.Parse(txtKullaniciID.Text);
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.AdiSoyadi = txtAdiSoyadi.Text;
            k.Soru = comboSoru.Text;
            k.Cevap = txtCevap.Text;
            k.Tarih = dateTimePickerGirisTarihi.Value;
            k.Aciklama = txtAciklama.Text;
            if (txtSifre.Text == txtSifreTekrardan.Text)
            {
                string sorgu = "update kullanicilar set KullaniciAdi='" + k.KullaniciAdi + "', Sifre='" + k.Sifre + "', " +
                "AdiSoyadi='" + k.AdiSoyadi + "', Soru='" + k.Soru + "', Cevap='" + k.Cevap + "', Tarih=@GirisTarihi, " +
                "Aciklama='" + k.Aciklama + "' where KullaniciID='" + k.KullaniciID + "' ";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = k.Tarih;
                Veritabani.ESG(komut, sorgu);
                Temizle();
                MessageBox.Show("İşlem Başarılı.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YenileListele();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor, tekrardan deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sorgu2 = "delete from kullanicilar  where kullaniciID='" + k.KullaniciID + "'";
            SqlCommand komut2 = new SqlCommand();
            Veritabani.ESG(komut2, sorgu2);
            Temizle();
            MessageBox.Show("İşlem Başarılı.", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            YenileListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kullanim dışı
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtKullaniciID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAdiSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtKullaniciIDAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select k.KullaniciID,k.KullaniciAdi,k.AdiSoyadi, k.Tarih,k.Aciklama from Kullanicilar k" +
                "where KullaniciID like'%"+txtKullaniciIDAra.Text+"%'");
        }

        private void textKullaniciAdiAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select k.KullaniciID,k.KullaniciAdi,k.AdiSoyadi, k.Tarih,k.Aciklama from Kullanicilar k" +
               "where KullaniciAdi like'%" + txtKullaniciAdiAra.Text + "%'");
        }

        private void txtAdiSoyadiAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select k.KullaniciID,k.KullaniciAdi,k.AdiSoyadi, k.Tarih,k.Aciklama from Kullanicilar k" +
              "where AdiSoyadi like'%" + txtAdiSoyadiAra.Text + "%'");
        }
    }
}
