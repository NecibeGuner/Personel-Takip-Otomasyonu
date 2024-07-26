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
    public partial class frmIzinListele : Form
    {
        Izin Izin = new Izin();
        public frmIzinListele()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
            Personeller.ComboyaKayitGetir(comboIzinTuru);

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

        private void btnIzinTurleri_Click(object sender, EventArgs e)
        {
            frmIzinTurleri frm = new frmIzinTurleri();
            frm.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIzinHareketID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboIzinTuru.Text = dataGridView1.CurrentRow.Cells["IzinTuru"].Value.ToString();
            dateTimeBaslangic.Text = dataGridView1.CurrentRow.Cells["IzinBaslangic"].Value.ToString();
            dateTimeBitis.Text = dataGridView1.CurrentRow.Cells["IzinBitis"].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelID, txtAdiSoyadi);
            if (txtPersonelID.Text == "")
            {
                txtAdiSoyadi.Text = "";
            }
        }

        private void frmIzinListele_Load(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, " select IzinID,PersonelID,KullaniciID,tur.IzinTuru,IzinBaslangic,IzinBitis," +
                "Aciklama,Tarih,Saat from IzinHareketleri i,IzinTurleri tur where i.IzinTurID=tur.IzinTurID");
            Personeller.ComboyaKayitGetir(comboIzinTuru);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Izin i = new Izin();
            i.IzinHareketID = int.Parse(txtIzinHareketID.Text);
            i.PERSONELID = int.Parse(txtPersonelID.Text);
            i.KullaniciID = Kullanicilar.kid;
            i.IzinTurID = (int)comboIzinTuru.SelectedValue;
            i.IzinBaslangic = dateTimeBaslangic.Value;
            i.IzinBitis = dateTimeBitis.Value;
            i.Aciklama = txtAciklama.Text;
            i.Tarih = DateTime.Now;
            i.Saat = DateTime.Now;
            i.Islem = i.IzinHareketID + " nolu izin bilgileri değiştirildi";
            string sql = "update IzinHareketleri set PersonelID='" + i.PERSONELID + "', IzinTurID='" + i.IzinTurID + "', IzinBaslangic=@izinBaslangic , " +
                "IzinBitis=@izinBitis,Islem='" + i.Islem + "', Aciklama='" + i.Aciklama + "',Tarih=@Tarih,Saat=@Saat where IzinID='" + i.IzinHareketID + "' ";


            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@izinBaslangic", SqlDbType.Date).Value = i.IzinBaslangic;
            komut.Parameters.Add("@izinBitis", SqlDbType.Date).Value = i.IzinBitis;
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = i.Tarih;
            komut.Parameters.Add("@Saat", SqlDbType.Date).Value = i.Saat;
            try
            {
                Veritabani.ESG(komut, sql);
                Temizle();
                MessageBox.Show("İzin bilgileri güncellendi.", "izin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Veritabani.Listele_Ara(dataGridView1, " select IzinID,PersonelID,KullaniciID,tur.IzinTuru,IzinBaslangic,IzinBitis," +
               "Aciklama,Tarih,Saat from IzinHareketleri i,IzinTurleri tur where i.IzinTurID=tur.IzinTurID");
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Uyarı");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Izin i = new Izin();
            i.IzinHareketID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sql = "delete from IzinHareketleri where IzinID='" + i.IzinHareketID + "' ";
            SqlCommand komut = new SqlCommand();

            try
            {
                Veritabani.ESG(komut, sql);
                Temizle();
                MessageBox.Show("İzin bilgileri silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Veritabani.Listele_Ara(dataGridView1, " select IzinID,PersonelID,KullaniciID,tur.IzinTuru,IzinBaslangic,IzinBitis," +
               "Aciklama,Tarih,Saat from IzinHareketleri i,IzinTurleri tur where i.iIzinTurID=tur.IzinTurID");
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Uyarı");
            }
        }
    }
}
