﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    class Kullanicilar
    {
        private int _KullaniciID;
        private string _KullaniciAdi;
        private string _Sifre;
        private string _AdiSoyadi;
        private string _Soru;
        private string _Cevap;
        private string _Aciklama;
        private DateTime _Tarih;
        private string _Rol;

        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string KullaniciAdi { get => _KullaniciAdi; set => _KullaniciAdi = value; }
        public string Sifre { get => _Sifre; set => _Sifre = value; }
        public string AdiSoyadi { get => _AdiSoyadi; set => _AdiSoyadi = value; }
        public string Soru { get => _Soru; set => _Soru = value; }
        public string Cevap { get => _Cevap; set => _Cevap = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public string Rol { get => _Rol; set => _Rol = value; }

        // Rol bilgisi

        public static bool durum = false;
        public static int kid = 0;
        public static string rol = "";  // Rol bilgisi static olarak saklananıyor
        public static SqlDataReader KullaniciGirisi(string kullaniciadi, string sifre)
        {
            Kullanicilar k = new Kullanicilar();
            k._KullaniciAdi = kullaniciadi;
            k._Sifre = sifre;
            Veritabani.connection.Open();
            SqlCommand komut = new SqlCommand("select * from kullanicilar where kullaniciadi = @kullaniciadi and sifre = @sifre", Veritabani.connection);
            komut.Parameters.AddWithValue("@kullaniciadi", k._KullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", k._Sifre);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = true;
                kid = int.Parse(dr["KullaniciID"].ToString());
                rol = dr["Rol"].ToString();  // Rol bilgisi alınır
            }
            else
            {
                durum = false;
            }
            dr.Close();
            Veritabani.connection.Close();
            return dr;
        }
        public static bool SoruCevapDogrula(int kullaniciID, string soru, string cevap)
        {
            bool dogrulandi = false;
            Veritabani.connection.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kullanicilar WHERE KullaniciID = @kullaniciID " +
                "AND Soru = @soru AND Cevap = @cevap", Veritabani.connection);
            komut.Parameters.AddWithValue("@kullaniciID", kullaniciID);
            komut.Parameters.AddWithValue("@soru", soru);
            komut.Parameters.AddWithValue("@cevap", cevap);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                dogrulandi = true;
            }
            dr.Close();
            Veritabani.connection.Close();
            return dogrulandi;
        }
    }
}