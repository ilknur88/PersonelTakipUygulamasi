
namespace personeltakip
{
    partial class İzinTipEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İzinTipEkleme));
            this.temizle = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.izintipno = new System.Windows.Forms.ColumnHeader();
            this.izintip = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.txtizintip = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtizintipno = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.PictureBox();
            this.güncelle = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ekle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.temizle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.güncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekle)).BeginInit();
            this.SuspendLayout();
            // 
            // temizle
            // 
            this.temizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temizle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.temizle.Image = ((System.Drawing.Image)(resources.GetObject("temizle.Image")));
            this.temizle.Location = new System.Drawing.Point(355, 450);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(93, 73);
            this.temizle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.temizle.TabIndex = 77;
            this.temizle.TabStop = false;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.izintipno,
            this.izintip});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(420, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(406, 393);
            this.listView1.TabIndex = 76;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // izintipno
            // 
            this.izintipno.Text = "İzin Tip No";
            this.izintipno.Width = 200;
            // 
            // izintip
            // 
            this.izintip.Text = "İzin Tip";
            this.izintip.Width = 200;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(175, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 1);
            this.label1.TabIndex = 75;
            // 
            // txtizintip
            // 
            this.txtizintip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtizintip.BackColor = System.Drawing.Color.Teal;
            this.txtizintip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtizintip.Location = new System.Drawing.Point(175, 243);
            this.txtizintip.Multiline = true;
            this.txtizintip.Name = "txtizintip";
            this.txtizintip.Size = new System.Drawing.Size(226, 36);
            this.txtizintip.TabIndex = 74;
            this.txtizintip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(12, 243);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 36);
            this.button5.TabIndex = 73;
            this.button5.Text = "İzin Tip:";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(175, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 1);
            this.label2.TabIndex = 72;
            // 
            // txtizintipno
            // 
            this.txtizintipno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtizintipno.BackColor = System.Drawing.Color.Teal;
            this.txtizintipno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtizintipno.Location = new System.Drawing.Point(175, 152);
            this.txtizintipno.Multiline = true;
            this.txtizintipno.Name = "txtizintipno";
            this.txtizintipno.Size = new System.Drawing.Size(226, 36);
            this.txtizintipno.TabIndex = 71;
            this.txtizintipno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 36);
            this.button2.TabIndex = 70;
            this.button2.Text = "İzin Tip No:";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sil
            // 
            this.sil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sil.Image = ((System.Drawing.Image)(resources.GetObject("sil.Image")));
            this.sil.Location = new System.Drawing.Point(493, 448);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(92, 75);
            this.sil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sil.TabIndex = 69;
            this.sil.TabStop = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // güncelle
            // 
            this.güncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.güncelle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.güncelle.Image = ((System.Drawing.Image)(resources.GetObject("güncelle.Image")));
            this.güncelle.Location = new System.Drawing.Point(214, 448);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(99, 75);
            this.güncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.güncelle.TabIndex = 68;
            this.güncelle.TabStop = false;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(702, 448);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ekle
            // 
            this.ekle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ekle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ekle.Image = ((System.Drawing.Image)(resources.GetObject("ekle.Image")));
            this.ekle.Location = new System.Drawing.Point(88, 448);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(90, 75);
            this.ekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ekle.TabIndex = 66;
            this.ekle.TabStop = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // İzinTipEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(838, 540);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtizintip);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtizintipno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "İzinTipEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.İzinTipEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temizle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.güncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox temizle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader izintipno;
        private System.Windows.Forms.ColumnHeader izintip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtizintip;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtizintipno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox sil;
        private System.Windows.Forms.PictureBox güncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ekle;
    }
}