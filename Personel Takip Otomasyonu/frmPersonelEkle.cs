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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaDepartmanGetir(comboDepartman);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Temizle()
        {
            dateTimePickerGirisTarihi.Value = DateTime.Now;
            comboDepartman.Text = "";
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
            Personeller p = new Personeller();
            Kullanicilar k = new Kullanicilar();
            p.Adi = txtAdi.Text;
            p.Soyadi = txtSoyadi.Text;
            p.Telefon = maskedtxtTelefon.Text;
            p.Adres = txtAdres.Text;
            p.Email = txtEmail.Text;
            p.DepartmanID = (int)comboDepartman.SelectedValue;
            p.Maasi = decimal.Parse(txtMaasi.Text);
            p.GirisTarihi = dateTimePickerGirisTarihi.Value;
            p.Aciklama = txtAciklama.Text;
            string sorgu = "insert into Personeller(Adi,Soyadi,Telefon,Adres,Email,DepartmanID,Maasi," +
                "GirisTarihi,Aciklama) values('" + p.Adi + "','" + p.Soyadi + "','" + p.Telefon + "'," +
                "'" + p.Adres + "','" + p.Email + "','" + p.DepartmanID + "',@Maasi, " +
                "@GirisTarihi,'" + p.Aciklama + "')";
            SqlCommand komut = new SqlCommand(sorgu);
            komut.Parameters.Add("@Maasi", SqlDbType.Decimal).Value = p.Maasi;
            komut.Parameters.Add("@GirisTarihi",SqlDbType.Date).Value = p.GirisTarihi;
            Veritabani.ESG(komut,sorgu);
            Personeller.PersonelIDSonKayit(p);
            p.Islem = p.PERSONELID + " nolu yeni personel kaydı oluşturuldu.";
            p.Aciklama = "Yeni personel ekleme";
            Personeller.PersonelIslemEkle(p, k);
            Temizle();
            MessageBox.Show("İşlem Başarılı...","Kayıt", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
