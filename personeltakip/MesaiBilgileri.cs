using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace personeltakip
{
    class MesaiBilgileri
    {
        private int mesaiNo;
        private string baslama;
        private string bitis;
        private decimal birimÜcret;
        private decimal toplamÜcret;
        private string dönem;
        private string ödemeHal;
        private string durumbilgisi;
        private DateTime tarih;
        

        public int MesaiNo { get => mesaiNo; set => mesaiNo = value; }
        public string Baslama { get => baslama; set => baslama = value; }
        public string Bitis { get => bitis; set => bitis = value; }
        public decimal BirimÜcret { get => birimÜcret; set => birimÜcret = value; }
        public decimal ToplamÜcret { get => toplamÜcret; set => toplamÜcret = value; }
        public string Dönem { get => dönem; set => dönem = value; }
        public string ÖdemeHal { get => ödemeHal; set => ödemeHal = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public string Durumbilgisi { get => durumbilgisi; set => durumbilgisi = value; }
        



    }
}
