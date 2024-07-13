using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    class Primler
    {
        #region KAPSULLEME
        private int _PrimID;
        private int _PersonelID;
        private int _KullaniciID;
        private string _Donem;
        private string _OdenmeDurumu;
        private decimal _PrimTutari;
        private string _Aciklama;
        private DateTime _Tarih;
        private string _Islem;

        public int PrimID { get => _PrimID; set => _PrimID = value; }
        public int PersonelID { get => _PersonelID; set => _PersonelID = value; }
        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string Donem { get => _Donem; set => _Donem = value; }
        public string OdenmeDurumu { get => _OdenmeDurumu; set => _OdenmeDurumu = value; }
        public decimal PrimTutari { get => _PrimTutari; set => _PrimTutari = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        #endregion

        public static SqlDataReader PersonelAdSoyadGetir(TextBox txtPersonelID,TextBox txtAdSoyad)
        {
            Veritabani.connection.Open();
            SqlCommand komut = new SqlCommand("select *from Personeller where PersonelID='" + txtPersonelID.Text + "'", Veritabani.connection);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAdSoyad.Text = dr[1] + " " + dr[2];
            }
            Veritabani.connection.Close();
            return dr;
        }
    }
}
