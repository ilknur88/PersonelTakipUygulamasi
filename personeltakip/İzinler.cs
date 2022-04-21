using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace personeltakip
{
    class İzinler:Calisanlar
    {
        public İzinler()
        {
            İzinler.data = "select *from İzinTipleri";
            İzinler.value = "İzinTipNo";
            İzinler.text = "İzinTip"; 
        }
        private int izinDurumNo;
        private int izinTipNo;
        private string izinTip;
        private DateTime baslangic;
        private DateTime bitis;
        private string durum;
        private DateTime tarih;

        public int IzinDurumNo { get => izinDurumNo; set => izinDurumNo = value; }
        public int IzinTipNo { get => izinTipNo; set => izinTipNo = value; }
        public string IzinTip { get => izinTip; set => izinTip = value; }
        public DateTime Baslangic { get => baslangic; set => baslangic = value; }
        public DateTime Bitis { get => bitis; set => bitis = value; }
        public string Durum { get => durum; set => durum = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }

        public static SqlDataReader ListvBilgiAta(ListView list)
        {
            list.Items.Clear();
            Data.baglanti.Open();
            SqlCommand kmt = new SqlCommand("select *from İzinTipleri",Data.baglanti);
            SqlDataReader rd = kmt.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem ata = new ListViewItem();
                ata.Text = rd[0].ToString();
                ata.SubItems.Add(rd[1].ToString());
                list.Items.Add(ata);
            }
            Data.baglanti.Close();
            return rd;
        }  
    }
}
