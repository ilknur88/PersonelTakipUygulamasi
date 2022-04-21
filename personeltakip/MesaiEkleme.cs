using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace personeltakip
{
    public partial class MesaiEkleme : Form
    {
        public MesaiEkleme()
        {
            InitializeComponent();
        }
        private void MesaiEkleme_Load(object sender, EventArgs e)
        {
            Zamlar.Combcalisanata(combcalisan);
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        } 
        private void combcalisan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zamlar.CombCalisanNoAta(combcalisan,label);  
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Calisanlar c = new Calisanlar();
            c.Calisanno = int.Parse(label.Text);
            MesaiBilgileri m = new MesaiBilgileri();         
            m.Baslama = dateTimePicker1.Text +"-"+ maskbaslama.Text;
            m.Bitis = dateTimePicker2.Text + "-" + maskbitis.Text;
            m.BirimÜcret = decimal.Parse(txtbirimücrt.Text);
            m.ToplamÜcret = decimal.Parse(txttoplamücrt.Text);
            m.Dönem = combay.Text + "/" + combyil.Text;
            m.Tarih = DateTime.Now;
            string data = "insert into Mesailer(Calisanno,Baslama,Bitis,BirimÜcret,ToplamÜcret,Dönem,Tarih)" +
                "values('" + c.Calisanno + "','"+m.Baslama+"','"+m.Bitis+"',@BirimÜcret," +
                "@ToplamÜcret,'"+m.Dönem+"',@Tarih)";
            SqlCommand kmt = new SqlCommand();
            kmt.Parameters.Add("@BirimÜcret", SqlDbType.Decimal).Value =m.BirimÜcret;
            kmt.Parameters.Add("@ToplamÜcret", SqlDbType.Decimal).Value = m.ToplamÜcret;
            kmt.Parameters.Add("@Tarih", SqlDbType.Date).Value = m.Tarih;
            Data.EkleSilGüncelle(kmt, data);
            MessageBox.Show("Mesai Ekleme Onaylandı");
        }
        private void txttoplamücrt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txtbirimücrt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslama = dateTimePicker1.Text + " " + maskbaslama.Text;
                string bitis = dateTimePicker2.Text + " " + maskbitis.Text;
                TimeSpan saatfark = DateTime.Parse(bitis) - DateTime.Parse(baslama);
                double birimÜcret = double.Parse(txtbirimücrt.Text);
                double toplamÜcret = saatfark.TotalHours * birimÜcret;
                txttoplamücrt.Text = toplamÜcret.ToString("0.00");

            }
            catch
            {
               
            }
        }
    }
}
