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

            string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "'," +
                "'" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            Veritabani.ESG(komut2, sql2);

            Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
            MessageBox.Show("Prim için dönem değişimi yapıldı.", "Dönem Değişikliği", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnTumPrimleriOde_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.OdenmeDurumu = "Ödendi";
            
            string sql = "update Primler set OdenmeDurumu='" + p.OdenmeDurumu + "'" +
                "where  OdenmeDurumu='Ödenmedi'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["OdenmeDurumu"].Value.ToString() == "Ödenmedi")
                {
                    Kullanicilar k = new Kullanicilar();
                    k.KullaniciID = Kullanicilar.kid;

                    p.PersonelID = int.Parse(dataGridView1.Rows[i].Cells["PersonelID"].Value.ToString());
                    p.PrimID = int.Parse(dataGridView1.Rows[i].Cells["PrimID"].Value.ToString());
                    p.Islem = "Tüm personellerin ödenmeyen primleri ödendi.";
                    p.Aciklama = "Tüm personellerin ödenmeyen primleri ödendi.";
                    
                    string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "'," +
                        "'" + p.PersonelID + "','" + p.PrimID + "', '" + p.Islem + "'," +
                        "'" + p.Aciklama + "',@Tarih)";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                    Veritabani.ESG(komut2, sql2);
                }
            }
        }
        private void btnPrimOde_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;

            Primler p = new Primler();
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.Aciklama = txtAciklama.Text;
            p.OdenmeDurumu = "Ödendi";
            p.Islem = p.PersonelID + " nolu personel " + txtPersonelAdSoyad.Text + " için ödeme yapıldı.";
            p.PrimID = int.Parse(txtPrimID.Text);
            p.Tarih = DateTime.Now;

            string sql = "update Primler set OdenmeDurumu='" + p.OdenmeDurumu + "' " +
                "where PrimID='"+p.PrimID+"'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);

            string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "'," +
                "'" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            Veritabani.ESG(komut2, sql2);

            Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
            MessageBox.Show("Seçili Personelin Primi Ödendi", "Prim Ödemeleri", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrimGuncelle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;

            Primler p = new Primler();
            p.PrimID = int.Parse(txtPrimID.Text);
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.PrimTutari = decimal.Parse(txtPrimTutari.Text);
            p.Aciklama = txtAciklama.Text;
            p.Islem = p.PrimID + " bilgileri değiştirildi.";

            string sql = "update Primler set PersonelID='" + p.PersonelID + "'," +
                "PrimTutari=@PrimTutari,Aciklama='" + p.Aciklama + "' where PrimID='" + p.PrimID + "'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@PrimTutari", SqlDbType.Decimal).Value = p.PrimTutari;
            Veritabani.ESG(komut, sql);

            string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "'," +
                "'" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            Veritabani.ESG(komut2, sql2);

            Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
            MessageBox.Show("Seçili Personelin Primi Bilgileri Güncellendi", "Prim Güncellemesi", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPrimSil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Kayıt Silinsin Mi?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Kullanicilar k = new Kullanicilar();
                k.KullaniciID = Kullanicilar.kid;
                Primler p = new Primler();
                p.PersonelID = int.Parse(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString());

                p.Aciklama = "Kayıt silindi";
                p.Islem = p.PrimID + " nolu prim kaydı silindi.";

                p.PrimID = int.Parse(dataGridView1.CurrentRow.Cells["PrimID"].Value.ToString());
                string sql = "delete from Primler where PrimID='" + p.PrimID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);

                /////////////
                string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "'," +
                    "'" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                Veritabani.ESG(komut2, sql2);
                /////////////
                ///
                Veritabani.Listele_Ara(dataGridView1, "select *from Primler");
                MessageBox.Show("Prim kaydı silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcelVeriAktarimi_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];

            // Sütun başlıklarını ekleyin
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                range.Value2 = dataGridView1.Columns[i].HeaderText;
            }

            // Verileri ekleyin
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[i + 2, j + 1];

                    if (dataGridView1.Columns[j].HeaderText == "PrimTutari")
                    {
                        if (decimal.TryParse(dataGridView1.Rows[i].Cells[j].Value?.ToString(), out decimal primTutari))
                        {
                            range.Value2 = primTutari;
                            range.NumberFormat = "0.00"; // Prim Tutarını iki ondalık basamakla formatlayın
                        }
                        else
                        {
                            range.Value2 = dataGridView1.Rows[i].Cells[j].Value;
                        }
                    }
                    else if (dataGridView1.Columns[j].HeaderText == "Tarih")
                    {
                        if (DateTime.TryParse(dataGridView1.Rows[i].Cells[j].Value?.ToString(), out DateTime tarih))
                        {
                            range.Value2 = tarih.ToOADate();
                            range.NumberFormat = "dd.mm.yyyy"; // Tarihi doğru formatta ayarlayın
                        }
                        else
                        {
                            range.Value2 = dataGridView1.Rows[i].Cells[j].Value;
                        }
                    }
                    else if (dataGridView1.Columns[j].HeaderText == "KullaniciID")
                    {
                        range.Value2 = dataGridView1.Rows[i].Cells[j].Value;
                        range.NumberFormat = "0.000"; // KullaniciID'yi doğru formatta ayarlayın
                    }
                    else
                    {
                        range.Value2 = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }
            }
        }
    }
}
