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
    }
}
