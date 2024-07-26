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
    public partial class frmPersoneleGorePrimler : Form
    {
        public frmPersoneleGorePrimler()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
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
