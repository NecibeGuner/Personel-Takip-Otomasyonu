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
    public partial class frmIzinTurleri : Form
    {
        public frmIzinTurleri()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIzinTurleri_Load(object sender, EventArgs e)
        {
            Izin.ListvieweKayitGetir(listView1);
        }
        private void Temizle()
        {
            txtIzinTuruID.Text = "";
            txtIzinTuru.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Izin i = new Izin();
                i.IzinTuru = txtIzinTuru.Text;
                string sql = "insert into IzinTurleri values('" + i.IzinTuru + "')";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                MessageBox.Show("Kayıt eklendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Izin.ListvieweKayitGetir(listView1);
                Temizle();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Türü");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Izin i = new Izin();
                i.IzinTurID = int.Parse(txtIzinTuruID.Text);
                i.IzinTuru = txtIzinTuru.Text;
                string sql = "update IzinTurleri set IzinTuru='" + i.IzinTuru + "' where IzinTurID='" + i.IzinTurID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                MessageBox.Show("Kayıt güncellendi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Izin.ListvieweKayitGetir(listView1);
                Temizle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Türü");
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtIzinTuruID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtIzinTuru.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Izin i = new Izin();
                i.IzinTurID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string sql = "delete from izinTurleri where izinTurID='" + i.IzinTurID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                MessageBox.Show("Kayıt silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Izin.ListvieweKayitGetir(listView1);
                Temizle();
            }
            else
            {
                MessageBox.Show("Önce kayıt seçilmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //kazar tıkladım

        }
    }
}
