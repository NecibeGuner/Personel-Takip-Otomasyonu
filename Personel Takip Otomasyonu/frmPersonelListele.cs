﻿using System;
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
    public partial class frmPersonelListele : Form
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }
        private void YenileListele()
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres," +
                "p.Email,d.[Departman ],p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama from Personeller p, " +
                "Departmanlar d where p.DepartmanID=d.DepartmanID");
            lblToplamKayit.Text = "Taplam Kayıt: " + (dataGridView1.RowCount - 1) + " kayıt listelenmiştir.";
            decimal toplammaas = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                toplammaas += decimal.Parse(dataGridView1.Rows[i].Cells["Maasi"].Value.ToString());
                lblToplamMaas.Text = "Toplam Maaş Tutarı: " + toplammaas.ToString("0,00") + " TL";
            }
        }
        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaKayitGetir(comboDepartman);
            YenileListele();
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
        Personeller p = new Personeller();
        Kullanicilar k = new Kullanicilar();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            p.PERSONELID = int.Parse(txtPersonelID.Text);
            p.Adi = txtAdi.Text;
            p.Soyadi = txtSoyadi.Text;
            p.Telefon = maskedtxtTelefon.Text;
            p.Adres = txtAdres.Text;
            p.Email = txtEmail.Text;
            p.DepartmanID = (int)comboDepartman.SelectedValue;
            p.Maasi = decimal.Parse(txtMaasi.Text);
            p.GirisTarihi = dateTimePickerGirisTarihi.Value;
            p.Aciklama = txtAciklama.Text;
            string sorgu = "update personeller set Adi='" + p.Adi + "', Soyadi='" + p.Soyadi + "', " +
                "Telefon='" + p.Telefon + "', Adres='" + p.Adres + "', Email='" + p.Email + "'," +
                " DepartmanID='" + p.DepartmanID + "',Maasi=@Maasi, GirisTarihi=@GirisTarihi, " +
                "Aciklama='" + p.Aciklama + "' where PersonelID='" + p.PERSONELID + "' ";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Maasi", SqlDbType.Decimal).Value = p.Maasi;
            komut.Parameters.Add("@GirisTarihi",SqlDbType.Date).Value = p.GirisTarihi;
            Veritabani.ESG(komut,sorgu);
            p.Islem = p.PERSONELID + " nolu personelin bilgileri güncellendi.";
            p.Aciklama = "Personel güncelleme";
            Personeller.PersonelIslemEkle(p,k);
            Temizle();
            MessageBox.Show("İşlem Başarılı.", "Güncelleme", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            YenileListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller(); 

            p.PERSONELID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sorgu2 = "update personeller set durumu='Pasif', CikisTarihi=@CikisTarihi " +
                "where personelID='" + p.PERSONELID + "'";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@CikisTarihi", SqlDbType.Date).Value = DateTime.Now;
            Veritabani.ESG(komut2, sorgu2);
            p.Islem = p.PERSONELID + " nolu personel işten çıkarıldı.";
            p.Aciklama = "İşten Çıkarma";
            Personeller.PersonelIslemEkle(p, k);
            Temizle();
            MessageBox.Show("İşlem Başarılı.", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            YenileListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedtxtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboDepartman.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtMaasi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dateTimePickerGirisTarihi.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void txtPersonelIDAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," +
                "d.[Departman ],p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama from Personeller p, Departmanlar " +
                "d where p.DepartmanID=d.DepartmanID and PersonelID like '%"+txtPersonelIDAra.Text+"%'");
        }
        private void txtPersonelAdAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," +
               "d.[Departman ],p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama from Personeller p, Departmanlar " +
               "d where p.DepartmanID=d.DepartmanID and Adi like '%" + txtPersonelAdAra.Text + "%'");
        }

        private void txtPersonelSoyadAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," +
              "d.[Departman ],p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama from Personeller p, Departmanlar " +
              "d where p.DepartmanID=d.DepartmanID and Soyadi like '%" + txtPersonelSoyadAra.Text + "%'");
        }

        private void txtPersonelTelefonAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," +
              "d.[Departman ],p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama from Personeller p, Departmanlar " +
              "d where p.DepartmanID=d.DepartmanID and Telefon like '%" + txtPersonelTelefonAra.Text + "%'");
        }

        private void dateTimePickerG_Tarihi_ValueChanged(object sender, EventArgs e)
        {
            Personeller.TariheGoreAra(dateTimePickerG_Tarihi, dataGridView1);
        }

        private void btnExcelVeriAktarimi_Click(object sender, EventArgs e)
        { 
            try
            {
                Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
                uyg.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];

                // Sütun başlıklarını ekler
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                    range.Value2 = dataGridView1.Columns[i].HeaderText;
                }

                // Verileri ekler
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[i + 2, j + 1];

                        // Maaş kolonunu doğru formatta ekler
                        if (dataGridView1.Columns[j].HeaderText == "Maasi")
                        {
                            if (decimal.TryParse(dataGridView1.Rows[i].Cells[j].Value?.ToString(), out decimal maas))
                            {
                                range.Value2 = maas;
                                range.NumberFormat = "0.00"; // İsteğe bağlı: Maaşı iki ondalık basamakla formatlar
                            }
                            else
                            {
                                range.Value2 = dataGridView1.Rows[i].Cells[j].Value;
                            }
                        }
                        else if (dataGridView1.Columns[j].HeaderText == "GirisTarihi")
                        {
                            if (DateTime.TryParse(dataGridView1.Rows[i].Cells[j].Value?.ToString(), out DateTime girisTarihi))
                            {
                                range.Value2 = girisTarihi.ToOADate();
                                range.NumberFormat = "dd.mm.yyyy"; // Giriş tarihini doğru formatta ayarlar
                            }
                            else
                            {
                                range.Value2 = dataGridView1.Rows[i].Cells[j].Value;
                            }
                        }
                        else
                        {
                            range.Value2 = dataGridView1.Rows[i].Cells[j].Value;
                        }

                        // Diğer kolonların formatlarını ayarlar
                        if (dataGridView1.Columns[j].HeaderText == "GirisTarihi")
                        {
                            range.NumberFormat = "dd.mm.yyyy";
                        }
                        else if (dataGridView1.Columns[j].HeaderText == "CikisTarihi")
                        {
                            range.NumberFormat = "dd.mm.yyyy hh:mm:ss";
                        }
                    }
                }

                MessageBox.Show("Veriler başarıyla Excel'e aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri aktarımı sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
