
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    public partial class frmPersonelMesaileri : Form
    {
        public frmPersonelMesaileri()
        {
            InitializeComponent();
        }
        private void frmPersonelMesaileri_Load(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridViewPersoneller, "select PersonelID as ID,Adi as ADI,soyadi as SOYADI from Personeller");
        }
        private void dataGridViewPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string PersonelID = dataGridViewPersoneller.CurrentRow.Cells["ID"].Value.ToString();
            Veritabani.Listele_Ara(dataGridViewMesailer, "select* from Mesailer where PersonelID='" + PersonelID + "'");
            txtPersonelIDAra.Text = dataGridViewPersoneller.CurrentRow.Cells["ID"].Value.ToString();
            try
            {
                lblKayitSayisi.Text = "Toplam" + (dataGridViewMesailer.Rows.Count - 1) + " kayıt listelendi.";
                decimal tutar = 0;
                for (int i = 0; i < dataGridViewMesailer.Rows.Count - 1; i++)
                {
                    tutar = tutar + (decimal.Parse(dataGridViewMesailer.Rows[i].Cells["Tutar"].Value.ToString()));
                }
                lblTutar.Text = "Toplam Mesai Ücreti=" + tutar.ToString("0.00") + "TL";
            }
            catch
            {

            }
        }
        private void txtMesaiIDAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridViewMesailer, "select *from Mesailer where MesaiID like '" + txtMesaiIDAra.Text + "'");
            if (txtMesaiIDAra.Text == "")
            {
                string PersonelID = txtPersonelIDAra.Text;
                Veritabani.Listele_Ara(dataGridViewMesailer, "select* from Mesailer where PersonelID='" + PersonelID + "'");
            }
        }
        private void txtPersonelIDAra_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelIDAra, txtAdSoyadAra);
        }

        private void btnExcelVeriAktarimi_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];

            // Sütun başlıklarını ekleyin
            for (int i = 0; i < dataGridViewMesailer.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                range.Value2 = dataGridViewMesailer.Columns[i].HeaderText;
            }

            // Verileri ekleyin
            for (int i = 0; i < dataGridViewMesailer.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridViewMesailer.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[i + 2, j + 1];
                    range.Value2 = dataGridViewMesailer[j, i].Value;

                    if (j == 1) // KullaniciID için
                    {
                        range.NumberFormat = "0.000";
                    }
                    if (j == 3 || j == 4) // Tarih formatı gereken hücreler
                    {
                        range.NumberFormat = "dd.MM.yyyy HH:mm";
                    }
                    if (j == 5) // MesaiÜcreti formatı için
                    {
                        range.NumberFormat = "#,##0.00 ₺"; // Para birimi formatı
                    }
                    if (j == 6) // Tutar formatı için
                    {
                        range.NumberFormat = "#,##0.00 ₺"; // Para birimi formatı
                    }
                    if (j == 10) // Dönem formatı gereken hücre
                    {
                        range.NumberFormat = "MM.yyyy";
                    }
                }
            }
        }
    }
}
