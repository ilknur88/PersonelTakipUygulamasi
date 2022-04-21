
namespace personeltakip
{
    partial class KisiselMesailer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KisiselMesailer));
            this.datagrdCalisanlar = new System.Windows.Forms.DataGridView();
            this.datagrdMesailer = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdCalisanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdMesailer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrdCalisanlar
            // 
            this.datagrdCalisanlar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datagrdCalisanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrdCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdCalisanlar.Location = new System.Drawing.Point(78, 12);
            this.datagrdCalisanlar.Name = "datagrdCalisanlar";
            this.datagrdCalisanlar.RowTemplate.Height = 25;
            this.datagrdCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrdCalisanlar.Size = new System.Drawing.Size(563, 220);
            this.datagrdCalisanlar.TabIndex = 0;
            this.datagrdCalisanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrdCalisanlar_CellClick);
            // 
            // datagrdMesailer
            // 
            this.datagrdMesailer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datagrdMesailer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrdMesailer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdMesailer.Location = new System.Drawing.Point(12, 248);
            this.datagrdMesailer.Name = "datagrdMesailer";
            this.datagrdMesailer.RowTemplate.Height = 25;
            this.datagrdMesailer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrdMesailer.Size = new System.Drawing.Size(782, 320);
            this.datagrdMesailer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(705, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // KisiselMesailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(806, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.datagrdMesailer);
            this.Controls.Add(this.datagrdCalisanlar);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KisiselMesailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KisiselMesailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrdCalisanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdMesailer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrdCalisanlar;
        private System.Windows.Forms.DataGridView datagrdMesailer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}