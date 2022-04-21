using System;
using System.Collections.Generic;
using System.Text;

namespace personeltakip
{
    class Uygkullanici
    {
        private int uygkulno;
        private string uygkulad;
        private string uygkulsifre;
        private string soru;
        private string cevap;
        private DateTime tarih;

        public int Uygkulno { get => uygkulno; set => uygkulno = value; }
        public string Uygkulad { get => uygkulad; set => uygkulad = value; }
        public string Uygkulsifre { get => uygkulsifre; set => uygkulsifre = value; }
        public string Soru { get => soru; set => soru = value; }
        public string Cevap { get => cevap; set => cevap = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
    }
}
