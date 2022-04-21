using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace personeltakip
{
    class Zamlar
    {
        private int zamno;
        private string dönem;
        private string çalisan;
        private decimal yüzde;
        private decimal fiyat;
        private DateTime tarih;

        public int Zamno { get => zamno; set => zamno = value; }
        public string Dönem { get => dönem; set => dönem = value; }
        public string Çalisan { get => çalisan; set => çalisan = value; }
        public decimal Yüzde { get => yüzde; set => yüzde = value; }
        public decimal Fiyat { get => fiyat; set => fiyat = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }

        public static SqlDataReader Combcalisanata(ComboBox comb)
        {
            Data.baglanti.Open();
            SqlCommand kmt = new SqlCommand("select CalisanNo,Ad,Soyad from Calisanlar ", Data.baglanti);
            SqlDataReader rd = kmt.ExecuteReader();
            while (rd.Read())
            {
                comb.Items.Add(rd[0] + "/" + rd[1] + " " + rd[2]);
            }
            Data.baglanti.Close();
            return rd;
        }
        public static SqlDataReader CombCalisanNoAta(ComboBox comb, Label lbl)
        {
            Data.baglanti.Open();
            SqlCommand kmt = new SqlCommand("select CalisanNo,Ad,Soyad from Calisanlar ", Data.baglanti);
            SqlDataReader rd = kmt.ExecuteReader();
            while (rd.Read())
            {
                if (comb.SelectedItem.ToString() == rd[0] + "/" + rd[1] + " " + rd[2]) 
                {
                    lbl.Text = rd[0].ToString();
                }
            }
            Data.baglanti.Close();
            return rd;
        }



    }
}
