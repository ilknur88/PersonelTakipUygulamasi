using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace personeltakip
{
    public partial class Uygkulgörev : Form
    {
        public Uygkulgörev()
        {
            InitializeComponent();
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();}
        private void button5_Click(object sender, EventArgs e)
        {
            MesaiEkleme ME = new MesaiEkleme();
            ME.Show(); }
        private void button9_Click(object sender, EventArgs e)
        {
            MesaiListele ML = new MesaiListele();
            ML.Show();   }
        private void button11_Click(object sender, EventArgs e)
        {
            İzinListele İL = new İzinListele();
            İL.Show();
        }
    }
}
