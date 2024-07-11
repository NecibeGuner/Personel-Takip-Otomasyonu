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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanicilar.KullaniciGirisi(txtKullaniciAdi.Text, txtSifre.Text);
            if (Kullanicilar.durum)
            {
                this.Hide();
                if (Kullanicilar.rol == "admin")
                {
                    frmAdminAnaSayfa adminAnaSayfa = new frmAdminAnaSayfa();
                    adminAnaSayfa.Show();
                }
                else
                {
                    frmAnaSayfa kullaniciAnaSayfa = new frmAnaSayfa();
                    kullaniciAnaSayfa.Show();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSifremiUnuttum frm = new frmSifremiUnuttum();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmYeniKullanici frm = new frmYeniKullanici();
            frm.ShowDialog();
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            //btnGiris.PerformClick();
        }
    }
}
