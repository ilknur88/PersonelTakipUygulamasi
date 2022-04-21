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
    public partial class İzinListele : Form
    {
        public İzinListele()
        {
            InitializeComponent();
        }
        İzinler izin = new İzinler();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            İzinTipEkleme İTE = new İzinTipEkleme();
            İTE.Show();
        }

        private void İzinListele_Load(object sender, EventArgs e)
        {
            Data.ListA(dataGridView1, "select İzinDurumNo,CalisanNo,it.İzinTip,Baslangic," +
                "Bitis,Durum,Tarih from İzinDurumBilgileri idb, İzinTipleri it where" +
                " idb.İzinTipNo=it.İzinTipNo");
            Calisanlar.KayıtGetir(combizintip);
        }

        private void txtcalno_TextChanged(object sender, EventArgs e)
        {
            İkramiyeler.CalisanBilgiAta(txtcalno, txtadsoyad);
            if (txtcalno.Text == "")
            {
                txtadsoyad.Text = "";
            }
        }
        private void Sil()
        {
            Calisanlar.KayıtGetir(combizintip);
            datebaslangic.Value = DateTime.Now;
            datebitis.Value = DateTime.Now;
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            İzinler iz = new İzinler();
            iz.Calisanno = int.Parse(txtcalno.Text);
            iz.IzinDurumNo = int.Parse(txtizindurumno.Text);
            iz.IzinTipNo = (int)combizintip.SelectedValue;
            iz.Baslangic = datebaslangic.Value;
            iz.Bitis = datebitis.Value;
            iz.Durum= iz.Calisanno + "/" + txtadsoyad.Text + "adlı birey için"
                + combizintip.Text + "mevcut hale getirildi";
            iz.Tarih = DateTime.Now;          
            string data = "insert into İzinDurumBilgileri values('"+iz.IzinDurumNo+"'," +
                "'"+iz.Calisanno+"','"+iz.IzinTipNo+"',@Baslangic,@Bitis,'"+iz.Durum+"',@Tarih) ";
            SqlCommand kmt = new SqlCommand();
            kmt.Parameters.Add("@Baslangic", SqlDbType.Date).Value = iz.Baslangic;
            kmt.Parameters.Add("@Bitis", SqlDbType.Date).Value = iz.Bitis;
            kmt.Parameters.Add("@Tarih", SqlDbType.Date).Value = iz.Tarih;

            try
            {
                Data.EkleSilGüncelle(kmt, data);
                Sil();
                MessageBox.Show("İzin ekleme işlemi onaylandı");
                Data.ListA(dataGridView1, "select İzinDurumNo,CalisanNo,it.İzinTip,Baslangic," +
               "Bitis,Durum,Tarih from İzinDurumBilgileri idb, İzinTipleri it where" +
               " idb.İzinTipNo=it.İzinTipNo");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "!");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtizindurumno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtcalno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            combizintip.Text = dataGridView1.CurrentRow.Cells["İzinTip"].Value.ToString();
            datebaslangic.Text = dataGridView1.CurrentRow.Cells["Baslangic"].Value.ToString();
            datebitis.Text = dataGridView1.CurrentRow.Cells["Bitis"].Value.ToString();
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            İzinler iz = new İzinler();
            iz.IzinDurumNo = int.Parse(txtizindurumno.Text);
            iz.Calisanno = int.Parse(txtcalno.Text);
            iz.IzinTipNo = (int)combizintip.SelectedValue;
            iz.Baslangic = datebaslangic.Value;
            iz.Bitis = datebitis.Value;
            iz.Durum = iz.IzinDurumNo + "nolu izin bilgi güncelleme işlemi onaylandı.";
            iz.Tarih = DateTime.Now;
            string data = "update İzinDurumBilgileri set CalisanNo='"+iz.Calisanno+"',İzinTipNo='"+iz.IzinTipNo+"'," +
                "Baslangic=@Baslangic,Bitis=@Bitis,Durum='"+iz.Durum+"',Tarih=@Tarih where İzinDurumNo='"+iz.IzinDurumNo+"' ";
            SqlCommand kmt = new SqlCommand();
            kmt.Parameters.Add("@Baslangic", SqlDbType.Date).Value = iz.Baslangic;
            kmt.Parameters.Add("@Bitis", SqlDbType.Date).Value = iz.Bitis;
            kmt.Parameters.Add("@Tarih", SqlDbType.Date).Value = iz.Tarih;

            try
            {
                Data.EkleSilGüncelle(kmt, data);
                Sil();
                MessageBox.Show("İzin güncelleme işlemi onaylandı");
                Data.ListA(dataGridView1, "select İzinDurumNo,CalisanNo,it.İzinTip,Baslangic," +
               "Bitis,Durum,Tarih from İzinDurumBilgileri idb, İzinTipleri it where" +
               " idb.İzinTipNo=it.İzinTipNo");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "!");
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            İzinler iz = new İzinler();
            iz.IzinDurumNo = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string data = "delete from İzinDurumBilgileri where İzinDurumNo='"+iz.IzinDurumNo+"'";
            SqlCommand kmt = new SqlCommand();
            try
            {
                Data.EkleSilGüncelle(kmt, data);
                Sil();
                MessageBox.Show("İzin silme işlemi onaylandı");
                Data.ListA(dataGridView1, "select İzinDurumNo,CalisanNo,it.İzinTip,Baslangic," +
               "Bitis,Durum,Tarih from İzinDurumBilgileri idb, İzinTipleri it where" +
               " idb.İzinTipNo=it.İzinTipNo");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "!");
            }
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
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
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
                   
                     pg.Range["D:D"].NumberFormat = "dd.mm.yyyy";
                     pg.Range["E:E"].NumberFormat = "dd.mm.yyyy";
                     pg.Range["G:G"].NumberFormat = "dd.mm.yyyy";
                }
            }
        }
    }
}
