using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace personeltakip
{
    class Data
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-98NKA0M\\SQLEXPRESS;Initial Catalog=ProjeYönetimi;Integrated Security=True");

        public static void EkleSilGüncelle(SqlCommand com, string data)
        {
            baglanti.Open();
            com.Connection = baglanti;
            com.CommandText = data;
            com.ExecuteNonQuery();
            baglanti.Close();
        }
        public static DataTable ListA(DataGridView grd,string data)
        {
            DataTable tb = new DataTable();
            baglanti.Open();
            SqlDataAdapter adp = new SqlDataAdapter(data, baglanti);
            adp.Fill(tb);
            grd.DataSource = tb;
            baglanti.Close();
            return tb;
        }

    }
}
