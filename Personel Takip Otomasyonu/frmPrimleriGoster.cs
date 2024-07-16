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
    public partial class frmPrimleriGoster : Form
    {
        public frmPrimleriGoster()
        {
            InitializeComponent();
        }

        private void frmPrimleriGoster_Load(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["OdenmeDurumu"].Value.ToString() == "Ödenmedi")
            {
                txtPrimID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPersonelID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPrimTutari.Text = dataGridView1.CurrentRow.Cells["PrimTutari"].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
            }
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelID, txtPersonelAdSoyad);
        }

        private void btnDonemDegistir_Click(object sender, EventArgs e)
        {
            //Primler p = new Primler();
            //p.Donem = comboAy.Text + "/" + comboYil.Text;
            //p.PrimID = int.Parse(txtPrimID.Text);
            //p.Tarih = DateTime.Now;
            //string sql = "update Primler set donem='" + p.Donem + "' where PrimID='" + p.PrimID + "'";
            //SqlCommand komut = new SqlCommand();
            //Veritabani.ESG(komut, sql);
            //Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
            //MessageBox.Show("Prim Dönemi Değiştirildi","Dönem Değişikliği",MessageBoxButtons.OK,MessageBoxIcon.Information);

            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;

            Primler p = new Primler();
            p.Donem = comboAy.Text + "/" + comboYil.Text;
            p.PrimID = int.Parse(txtPrimID.Text);
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.Islem = "Dönem bilgisi değişti.";
            p.Aciklama = "Seçili kaydın dönem bilgisi değişti.";
            p.Tarih = DateTime.Now;
            string sql = "update Primler set donem='" + p.Donem + "' where PrimID='" + p.PrimID + "'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);

            //string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "'," +
            //    "'" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
            //SqlCommand komut2 = new SqlCommand();
            //komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            //Veritabani.ESG(komut2, sql2);

            Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
            MessageBox.Show("Prim için dönem değişimi yapıldı.", "Dönem Değişikliği", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnTumPrimleriOde_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.OdenmeDurumu = "Ödendi";
            string sql = "update Primler set OdenmeDurumu='" + p.OdenmeDurumu + "' where OdenmeDurumu='Ödenmedi'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
            MessageBox.Show("Ödenmeyen Tüm Primler Ödendi", "Prim Ödemeleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPrimOde_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.OdenmeDurumu = "Ödendi";
            p.PrimID = int.Parse(txtPrimID.Text);
            string sql = "update Primler set OdenmeDurumu='" + p.OdenmeDurumu + "' where PrimID='"+p.PrimID+"'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
            MessageBox.Show("Seçili Personelin Primi Ödendi", "Prim Ödemeleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrimGuncelle_Click(object sender, EventArgs e)
        {

            Primler p = new Primler();

            //Kullanicilar k = new Kullanicilar();
            //k.KullaniciID = Kullanicilar.kid;

            p.PrimID = int.Parse(txtPrimID.Text);
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.PrimTutari = decimal.Parse(txtPrimTutari.Text);
            p.Aciklama = txtAciklama.Text;
            p.Islem = p.PrimID + " bilgileri değiştirildi.";

            string sql = "update Primler set PersonelID='" + p.PersonelID + "',PrimTutari=@PrimTutari,Aciklama='" + p.Aciklama + "' where PrimID='" + p.PrimID + "'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@PrimTutari", SqlDbType.Decimal).Value = p.PrimTutari;
            Veritabani.ESG(komut, sql);

            //string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "'," +
            //   "'" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
            //SqlCommand komut2 = new SqlCommand();
            //komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            //Veritabani.ESG(komut2, sql2);

            Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
            MessageBox.Show("Seçili Personelin Primi Bilgileri Güncellendi", "Prim Güncellemesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPrimSil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Kayıt Silinsin Mi?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Primler p = new Primler();
                p.PrimID = int.Parse(dataGridView1.CurrentRow.Cells["PrimID"].Value.ToString());
                string sql = "delete from Primler where PrimID='" + p.PrimID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
                MessageBox.Show("Seçili Personelin Primi Kaydı Silindi", "Prim Güncellemesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
