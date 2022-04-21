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
    public partial class İzinTipEkleme : Form
    {
        public İzinTipEkleme()
        {
            InitializeComponent();
        }
        private void İzinTipEkleme_Load(object sender, EventArgs e)
        {
            İzinler.ListvBilgiAta(listView1);
        }
        private void bilgitemizle()
        {
            txtizintipno.Text = "";
            txtizintip.Text = "";
        }
        private void ekle_Click(object sender, EventArgs e)
        { 
              try
                {
                    İzinler i = new İzinler();
                    i.IzinTip = txtizintip.Text;
                    string data = "insert into İzinTipleri values('" + i.IzinTip + "')";
                    SqlCommand kmt2 = new SqlCommand();
                    Data.EkleSilGüncelle(kmt2, data);
                    MessageBox.Show("İzin Tip Ekleme Onaylandı");
                    İzinler.ListvBilgiAta(listView1);
                    bilgitemizle();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "!");
                } 
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                İzinler i = new İzinler();
                i.IzinTip = txtizintip.Text;
                i.IzinTipNo = int.Parse(txtizintipno.Text);
                string data = "update İzinTipleri set İzinTip='" + i.IzinTip + "' where İzinTipNo='" + i.IzinTipNo + "'";
                SqlCommand kmt = new SqlCommand();
                Data.EkleSilGüncelle(kmt, data);
                MessageBox.Show("İzin Tip Güncelleme Onaylandı");
                İzinler.ListvBilgiAta(listView1);
                bilgitemizle();
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
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                İzinler i = new İzinler();
                i.IzinTipNo = int.Parse(txtizintipno.Text);
                string data = "delete from İzinTipleri where İzinTipNo='" + i.IzinTipNo + "'";
                SqlCommand kmt = new SqlCommand();
                Data.EkleSilGüncelle(kmt, data);
                MessageBox.Show("Silme İşlemi Onaylandı");
                İzinler.ListvBilgiAta(listView1);
                bilgitemizle();
            }
            else
            {
                MessageBox.Show("Kayıt Seç!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtizintipno.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtizintip.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }
    }
}
