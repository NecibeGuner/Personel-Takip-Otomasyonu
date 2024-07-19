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
    class Veritabani
    {
        public static SqlConnection connection = new SqlConnection
            ("Data Source=NECIBE-03\\SQLEXPRESS01;Initial Catalog=Personel_Takip;Integrated Security=True;Pooling=False;Encrypt=False");
        public static void ESG(SqlCommand cmd,string sql)
        {
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static DataTable Listele_Ara(DataGridView gridView, string sql)
        {
            DataTable tbl = new DataTable();
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, connection);
            adtr.Fill(tbl);
            gridView.DataSource = tbl;
            connection.Close();
            return tbl;
        }
    }
}
