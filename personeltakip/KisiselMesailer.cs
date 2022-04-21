using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace personeltakip
{
    public partial class KisiselMesailer : Form
    {
        public KisiselMesailer()
        {
            InitializeComponent();
        }
        private void KisiselMesailer_Load(object sender, EventArgs e)
        {
            Data.ListA(datagrdCalisanlar, "select CalisanNo as NO,Ad as AD, Soyad as SOYAD from Calisanlar");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void datagrdCalisanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Calisanno = datagrdCalisanlar.CurrentRow.Cells["NO"].Value.ToString();
            Data.ListA(datagrdMesailer, "select *from Mesailer where Calisanno='" + Calisanno + "'");

        }
    }
}
