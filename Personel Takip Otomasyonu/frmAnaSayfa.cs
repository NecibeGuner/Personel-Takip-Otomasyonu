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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
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

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            //kazara tıklandı
        }

        private void btnMaasZamlari_Click(object sender, EventArgs e)
        {
            frmYapilanZamlar k = new frmYapilanZamlar();
            k.ShowDialog();
        }

        private void frmAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPirimler_Click(object sender, EventArgs e)
        {
            frmPrimler frm = new frmPrimler();
            frm.ShowDialog();
        }

        private void btnMesaiListele_Click(object sender, EventArgs e)
        {
            frmMesailer frm = new frmMesailer();
            frm.ShowDialog();
        }

        private void btnIzinEkle_Click(object sender, EventArgs e)
        {
            frmIzinEkle frm = new frmIzinEkle();
            frm.ShowDialog();
        }

        private void btnIzinListele_Click(object sender, EventArgs e)
        {
            frmIzinListele frm = new frmIzinListele();
            frm.ShowDialog();
        }
    }
}
