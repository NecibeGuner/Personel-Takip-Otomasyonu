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
    public partial class frmAdminAnaSayfa : Form
    {
        public frmAdminAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnDepartmanlar_Click(object sender, EventArgs e)
        {
            frmDepartmanlar frm = new frmDepartmanlar();
            frm.ShowDialog();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle();
            frm.ShowDialog();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            frmPersonelListele frm = new frmPersonelListele();
            frm.ShowDialog();
        }

        private void btnMaasZamlari_Click(object sender, EventArgs e)
        {
            frmYapilanZamlar k = new frmYapilanZamlar();
            k.ShowDialog();
        }

        private void btnKullaniciListele_Click(object sender, EventArgs e)
        {
            frmKullaniciListesi k = new frmKullaniciListesi();
            k.ShowDialog();
        }

        private void frmAdminAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle frm = new frmKullaniciEkle();
            frm.ShowDialog();
        }

        private void btnPirimler_Click(object sender, EventArgs e)
        {
            frmPrimler frm = new frmPrimler();
            frm.ShowDialog();
        }
    }
}
