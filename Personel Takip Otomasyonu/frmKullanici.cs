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
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanicilar.KullaniciGirisi(txtKullaniciAdi.Text,txtSifre.Text);
            if (Kullanicilar.durum)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
