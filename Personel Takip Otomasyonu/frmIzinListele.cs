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
    public partial class frmIzinListele : Form
    {
        public frmIzinListele()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzinTurleri_Click(object sender, EventArgs e)
        {
            frmIzinTurleri frm = new frmIzinTurleri();
            frm.ShowDialog();
        }
    }
}
