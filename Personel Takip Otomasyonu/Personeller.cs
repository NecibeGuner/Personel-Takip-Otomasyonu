using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    class Personeller
    {
        private int _PersonelID;
        private string _Adi;
        private string _Soyadi;
        private string _Telefon;
        private string _Adres;
        private string _Email;
        private int _DepartmanID;
        private decimal _Maasi;
        private DateTime _GirisTarihi;
        private string _Aciklama;

        public int PERSONELID { get => _PersonelID; set => _PersonelID = value; }
        public string Adi { get => _Adi; set => _Adi = value; }
        public string Soyadi { get => _Soyadi; set => _Soyadi = value; }
        public string Telefon { get => _Telefon; set => _Telefon = value; }
        public string Adres { get => _Adres; set => _Adres = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        public decimal Maasi { get => _Maasi; set => _Maasi = value; }
        public DateTime GirisTarihi { get => _GirisTarihi; set => _GirisTarihi = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }

        public static DataTable ComboyaDepartmanGetir(ComboBox combo)
        {
            DataTable tbl = new DataTable();
            Veritabani.connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT DepartmanID, Departman FROM Departmanlar", Veritabani.connection);
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.ValueMember = "DepartmanID";//arka planda tuttuğu kısım
            combo.DisplayMember = "Departman";//görünecek olan kısım
            Veritabani.connection.Close();
            return tbl;
        }
    }
}
