using Microsoft.Office.Interop.Excel;
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
    public partial class frmDepartmanlar : Form
    {
        public frmDepartmanlar()
        {
            InitializeComponent();
        }

        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.Departman = txtDepartman.Text;
            d.Aciklama = txtAciklama.Text;
            string sorgu = "insert into Departmanlar values('" + d.Departman + "','" + d.Aciklama + "')";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sorgu);
            MessageBox.Show("İşlem Başarılı...");
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.DepartmanID = int.Parse(txtDepartmanID.Text);
            d.Departman = txtDepartman.Text;
            d.Aciklama = txtAciklama.Text;
            string sorgu = "update departmanlar set departman='" + d.Departman + "',aciklama='" + d.Aciklama + "'" +
                "where departmanID='" + d.DepartmanID + "'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sorgu);
            MessageBox.Show("İşlem Başarılı...");
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                Departmanlar d = new Departmanlar();
                d.DepartmanID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string sorgu = "delete from where departmanID='" + d.DepartmanID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sorgu);
                MessageBox.Show("İşlem Başarılı...");
                Departmanlar.DepartmanGetir(listView1);
            }
            else 
            {
                MessageBox.Show("Önce Kayıt Seçmelisiniz...", "UYARI", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtDepartmanID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtDepartman.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = listView1.SelectedItems[0].SubItems[2].Text;
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
            // ListView sütun başlıklarını Excel'e ekleyin
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                Range range = (Range)sayfa.Cells[1, i + 1];
                range.Value2 = listView1.Columns[i].Text;
            }

            // ListView verilerini Excel'e ekleyin
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int j = 0; j < listView1.Items[i].SubItems.Count; j++)
                {
                    Range range = (Range)sayfa.Cells[i + 2, j + 1];
                    range.Value2 = listView1.Items[i].SubItems[j].Text;
                }
            }
        }
        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //kazara tıkladım bir işe yaramıyor
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kazara tıklandı
        }
    }
}