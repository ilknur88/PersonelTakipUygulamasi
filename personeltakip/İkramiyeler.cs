using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace personeltakip
{
    class İkramiyeler
    {
        private int ikramiyeno;
        private int calisanno;
        private string dönem;
        private decimal tutar;
        private DateTime tarih;
        private string ödenmehali;

        public int Ikramiyeno { get => ikramiyeno; set => ikramiyeno = value; }
        public int Calisanno { get => calisanno; set => calisanno = value; }
        public string Dönem { get => dönem; set => dönem = value; }
        public decimal Tutar { get => tutar; set => tutar = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public string Ödenmehali { get => ödenmehali; set => ödenmehali = value; }
    
        public static SqlDataReader CalisanBilgiAta(TextBox txtcalno,TextBox txtadsoyad)
        {
            Data.baglanti.Open();
            SqlCommand kmt = new SqlCommand("select *from Calisanlar where " +
                "CalisanNo='" + txtcalno.Text + "'", Data.baglanti);
            SqlDataReader rd = kmt.ExecuteReader();
            while (rd.Read())
            {
                txtadsoyad.Text = rd[1] + " " + rd[2];
            }
            Data.baglanti.Close();
            return rd;

        }
    }
}
