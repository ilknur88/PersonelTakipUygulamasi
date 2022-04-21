using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace personeltakip
{
    class Calisanlar
    {
        private int calisanno;
        private string ad;
        private string soyad;
        private string telefon;
        private string email;
        private int alanno;
        private decimal ücretbilgisi;
        private string görev;
        private DateTime giris;

        public int Calisanno { get => calisanno; set => calisanno = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public int Alanno { get => alanno; set => alanno = value; }
        public decimal Ücretbilgisi { get => ücretbilgisi; set => ücretbilgisi = value; }
        public string Görev { get => görev; set => görev = value; }
        public DateTime Giris { get => giris; set => giris = value; }


        public static string data = "select *from Alanlar";
        public static string value = "Alanno";
        public static string text = "Alan";
        public static DataTable KayıtGetir(ComboBox cmb)
        {
            DataTable tb = new DataTable();
            Data.baglanti.Open();
            SqlDataAdapter adp = new SqlDataAdapter(data, Data.baglanti);
            adp.Fill(tb);
            cmb.DataSource = tb;
            cmb.ValueMember = value;
            cmb.DisplayMember = text;
            Data.baglanti.Close();
            return tb;
        }
    }
}
