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
    public partial class frmMesailer : Form
    {
        public frmMesailer()
        {
            InitializeComponent();
        }
        private void frmMesailer_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }
            Veritabani.Listele_Ara(dataGridView1, "select *from Mesailer");
        }
        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelID, txtPersonelAdSoyad);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMesaiID.Text = dataGridView1.CurrentRow.Cells["MesaiID"].Value.ToString();
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString();
            txtMesaiSaatUcreti.Text = dataGridView1.CurrentRow.Cells["MesaiUcreti"].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
            string baslangic = dataGridView1.CurrentRow.Cells["BaslangicSaati"].Value.ToString();
            string bitis = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
            string donem = dataGridView1.CurrentRow.Cells["Donem"].Value.ToString();
            dateTimeBaslangic.Text = baslangic.Substring(0, 10);
            maskedTxtBaslangic.Text = baslangic.Substring(11);
            dateTimeBitis.Text = bitis.Substring(0, 10);
            maskedTxtBitis.Text = bitis.Substring(11);
            int say = donem.IndexOf("/");
            comboAy.Text = donem.Substring(0, say);
            comboYil.Text = donem.Substring(say + 1);
        }

        private void txtMesaiSaatUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangic = dateTimeBaslangic.Text + " " + maskedTxtBaslangic.Text;
                string bitis = dateTimeBitis.Text + " " + maskedTxtBitis.Text;
                TimeSpan saatfarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                double MSaatUcreti = double.Parse(txtMesaiSaatUcreti.Text);
                double tutar = saatfarki.TotalHours * MSaatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch { }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
