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
    public partial class frmMesaiEkle : Form
    {
        public frmMesaiEkle()
        {
            InitializeComponent();
        }

        private void frmMesaiEkle_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }
            YapilanZamlar.ComboyaPersonelGetir(comboPersonelAdSoyad);
        }

        Label lbl;
        private void comboPersonelAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl = new Label();
            YapilanZamlar.ComboSecilirsePersonenelIDGetir(comboPersonelAdSoyad, lbl);
            MessageBox.Show(lbl.Text);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            Personeller p = new Personeller();
            Mesailer m = new Mesailer();

            k.KullaniciID = Kullanicilar.kid;
            p.PERSONELID = int.Parse(lbl.Text);
            m.BaslangicSaati = dateTimeBaslangic.Text + " " + maskedTxtBaslangic;
            m.BitisSaati = dateTimeBitis.Text + " " + maskedTxtBitis.Text;
            m.MesaiSaatUcreti = decimal.Parse(txtMesaiSaatUcreti.Text);
            m.Tutar = decimal.Parse(txtTutar.Text);
            m.Donem = comboAy.Text + "/" + comboYil.Text;
            m.Aciklama = txtAciklama.Text;
            m.Tarih = DateTime.Now;

            string sql = "insert into Mesailer(KullaniciID, PersonelID, BaslangicSaati, BitisSaati, " +
                "MesaaiUcreti, Tutar, Donem, Aciklama, Tarih) values('" + k.KullaniciID + "'," +
                "'" + p.PERSONELID + "','" + m.BaslangicSaati + "','" + m.BitisSaati + "'," +
                "@MSaatUcreti,@Tutar ,'" + m.Donem + "','" + m.Aciklama + "', @Tarih";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@MSaatUcreti", SqlDbType.Decimal).Value = m.MesaiSaatUcreti;
            komut.Parameters.Add("@Tutar", SqlDbType.Decimal).Value = m.Tutar;
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = m.Tarih;
            Veritabani.ESG(komut, sql);

            MessageBox.Show("Mesai bilgileri eklendi.", "Mesailer", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMesaiSaatUcreti_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
