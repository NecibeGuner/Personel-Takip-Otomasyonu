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
    public partial class frmYeniKullanici : Form
    {
        public frmYeniKullanici()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.AdiSoyadi = txtAdSoyad.Text;
            k.Soru = comboBoxSoru.Text;
            k.Cevap = txtCevap.Text;
            k.Aciklama = txtAciklama.Text;
            //k.Tarih = 

            string sql = "insert into Kullanicilar(KullaniciAdi,Sifre,AdiSoyadi,Soru,Cevap,Aciklama) values('" + k.KullaniciAdi + "'," +
                "'" + k.Sifre + "','" + k.AdiSoyadi + "','" + k.Soru + "','" + k.Cevap + "','" + k.Aciklama + "')";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut,sql);
        }
    }
}
