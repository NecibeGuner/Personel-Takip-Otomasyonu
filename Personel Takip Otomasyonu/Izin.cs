using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    class Izin:Personeller
    {
        //public Izin()
        //{
        //    Izin.sql = "select *from IzinTurleri";
        //    Izin.value = "IzinTurID";
        //    Izin.text = "IzinTuru";
        //}

        private int _izinHareketID;
        private int _izinTurID;
        private int _kullaniciID;
        private string _izinTuru;
        private DateTime _izinBaslangic;
        private DateTime _izinBitis;
        private DateTime _saat;

        public int IzinHareketID { get => _izinHareketID; set => _izinHareketID = value; }
        public int IzinTurID { get => _izinTurID; set => _izinTurID = value; }
        public int KullaniciID { get => _kullaniciID; set => _kullaniciID = value; }
        public string IzinTuru { get => _izinTuru; set => _izinTuru = value; }
        public DateTime IzinBaslangic { get => _izinBaslangic; set => _izinBaslangic = value; }
        public DateTime IzinBitis { get => _izinBitis; set => _izinBitis = value; }
        public DateTime Saat { get => _saat; set => _saat = value; }

        public static SqlDataReader ListvieweKayitGetir(ListView lst)
        {
            lst.Items.Clear();
            Veritabani.connection.Open();
            SqlCommand komut = new SqlCommand("select *from IzinTurleri", Veritabani.connection);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                lst.Items.Add(ekle);
            }
            Veritabani.connection.Close();
            return dr;
        }
    }
}
