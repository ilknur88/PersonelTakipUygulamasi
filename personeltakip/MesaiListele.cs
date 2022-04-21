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
    public partial class MesaiListele : Form
    {
        public MesaiListele()
        {
            InitializeComponent();
        }

        private void MesaiListele_Load(object sender, EventArgs e)
        {
            Data.ListA(dataGridView1, "Select *from Mesailer");
        }

        private void txtcalno_TextChanged(object sender, EventArgs e)
        {

            İkramiyeler.CalisanBilgiAta(txtcalno, txtadsoyad);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["ÖdemeHal"].Value.ToString()=="Ödenmedi")
            {
                txtmesaino.Text = dataGridView1.CurrentRow.Cells["MesaiNo"].Value.ToString();
                txtcalno.Text = dataGridView1.CurrentRow.Cells["Calisanno"].Value.ToString();
                txtbirimücrt.Text = dataGridView1.CurrentRow.Cells["BirimÜcret"].Value.ToString();
                string baslangic = dataGridView1.CurrentRow.Cells["Baslama"].Value.ToString();
                string bitis = dataGridView1.CurrentRow.Cells["Bitis"].Value.ToString();
                string donem = dataGridView1.CurrentRow.Cells["Dönem"].Value.ToString();
                dateTimePicker1.Text = baslangic.Substring(0, 10);
                maskbaslama.Text = baslangic.Substring(11);
                dateTimePicker2.Text = bitis.Substring(0, 10);
                maskbitis.Text = bitis.Substring(11);
                int no = donem.IndexOf("/");
                combay.Text = donem.Substring(0, no);
                combyil.Text = donem.Substring(no + 1);
            }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            KisiselMesailer KM = new KisiselMesailer();
            KM.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void mesaiÖde_Click(object sender, EventArgs e)
        {
            MesaiBilgileri mb = new MesaiBilgileri();
            Calisanlar ca = new Calisanlar();
            ca.Calisanno = int.Parse(txtcalno.Text);
            mb.ÖdemeHal = "Ödendi";
            mb.MesaiNo = int.Parse(txtmesaino.Text);
            mb.Durumbilgisi = mb.MesaiNo + "nolu mesai ödeme onaylandı";
            string data = "update Mesailer set ÖdemeHal='"+mb.ÖdemeHal+"' where ÖdemeHal='Ödenmedi' ";
            SqlCommand kmt = new SqlCommand();
            MesaiDurumEkle(mb, ca);
            Data.EkleSilGüncelle(kmt, data);
            Data.ListA(dataGridView1, "Select *from Mesailer");
            MessageBox.Show("Ödeme İşlemi Onaylandı");
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                if (dataGridView1.Rows[i].Cells["ÖdemeHal"].Value.ToString() == "Ödenmedi")
                {
                    mb.MesaiNo = int.Parse(dataGridView1.Rows[i].Cells["MesaiNo"].Value.ToString());
                    ca.Calisanno = int.Parse(dataGridView1.Rows[i].Cells["Calisanno"].Value.ToString());
                    mb.Durumbilgisi = mb.MesaiNo +"nolu mesai ödeme onaylandı";
                    MesaiDurumEkle(mb, ca);
                }
            }

        }

        private void seciliMesaiÖde_Click(object sender, EventArgs e)
        {
            MesaiBilgileri mb = new MesaiBilgileri();
            Calisanlar ca = new Calisanlar();
            ca.Calisanno = int.Parse(txtcalno.Text);
            mb.ÖdemeHal = "Ödendi";
            mb.MesaiNo = int.Parse(txtmesaino.Text);
            mb.Durumbilgisi = mb.MesaiNo + "nolu mesai ödeme onaylandı";
            string data = "update Mesailer set ÖdemeHal='" + mb.ÖdemeHal + "' where MesaiNo='" + mb.MesaiNo + "' ";
            SqlCommand kmt = new SqlCommand();
            MesaiDurumEkle(mb, ca);
            Data.EkleSilGüncelle(kmt, data);
            Data.ListA(dataGridView1, "Select *from Mesailer");
            MessageBox.Show("Seçilen" +mb.MesaiNo+"inci Ödeme Onaylandı");
           
        }
        void MesaiDurumEkle(MesaiBilgileri mb, Calisanlar ca)
        {
            string data = "insert into MesaiDurumBilgileri values('"+ca.Calisanno+"','"+mb.Durumbilgisi+"',@Tarih) ";
            SqlCommand kmt = new SqlCommand();
            kmt.Parameters.Add("@Tarih", SqlDbType.Date).Value = DateTime.Now;
            Data.EkleSilGüncelle(kmt, data);
        }

        private void sil_Click(object sender, EventArgs e)
        {   
            MesaiBilgileri mb = new MesaiBilgileri();        
            Calisanlar ca = new Calisanlar();
            ca.Calisanno = int.Parse(txtcalno.Text);
            mb.MesaiNo = int.Parse(txtmesaino.Text);
            mb.Durumbilgisi = mb.MesaiNo + "nolu mesai silme onaylandı";
            string data = "delete from Mesailer where MesaiNo='" + mb.MesaiNo + "' ";
            SqlCommand kmt = new SqlCommand();
            MesaiDurumEkle(mb, ca);
            Data.EkleSilGüncelle(kmt, data);
            Data.ListA(dataGridView1, "Select *from Mesailer");
            MessageBox.Show("Seçilen" + mb.MesaiNo + "inci Kayıt Silme İşlemi Onaylandı");
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            MesaiBilgileri mb = new MesaiBilgileri();
            Calisanlar ca = new Calisanlar();
            ca.Calisanno = int.Parse(txtcalno.Text);
            mb.MesaiNo = int.Parse(txtmesaino.Text);
            mb.Baslama = dateTimePicker1.Text + " " + maskbaslama.Text;
            mb.Bitis = dateTimePicker2.Text + " " + maskbitis.Text;
            mb.BirimÜcret = decimal.Parse(txtbirimücrt.Text);
            mb.ToplamÜcret = decimal.Parse(txttoplamücrt.Text);
            mb.Dönem = combay.Text + "-" + combyil.Text;
            string data = "update Mesailer set Calisanno='"+ca.Calisanno+"', Baslama='"+mb.Baslama+"', Bitis='"+mb.Bitis+"'," +
                "BirimÜcret=@BirimÜcret, ToplamÜcret=@ToplamÜcret, Dönem='"+mb.Dönem+"' where MesaiNo='"+mb.MesaiNo+"' ";
            SqlCommand kmt = new SqlCommand();
            kmt.Parameters.Add("@BirimÜcret", SqlDbType.Decimal).Value = mb.BirimÜcret;
            kmt.Parameters.Add("@ToplamÜcret", SqlDbType.Decimal).Value = mb.ToplamÜcret; 
            MesaiDurumEkle(mb, ca);
            Data.EkleSilGüncelle(kmt, data);
            mb.Durumbilgisi = mb.MesaiNo + "nolu mesai güncelleme onaylandı";
            Data.ListA(dataGridView1, "Select *from Mesailer");
            MessageBox.Show("Güncelleme İşlemi Onaylandı");
        }

        private void exceleaktar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook bk = app.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet pg = (Microsoft.Office.Interop.Excel.Worksheet)bk.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range rng = (Microsoft.Office.Interop.Excel.Range)pg.Cells[1, i + 1];
                rng.Value2 = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range rng = (Microsoft.Office.Interop.Excel.Range)pg.Cells[j + 2, i + 1];
                    rng.Value2 = dataGridView1[i, j].Value;
                    pg.Range["C:C"].NumberFormat = "dd.mm.yyyy";
                    pg.Range["D:D"].NumberFormat = "dd.mm.yyyy";
                    pg.Range["I:I"].NumberFormat = "dd.mm.yyyy";
                }
            }
        }
    }
}
