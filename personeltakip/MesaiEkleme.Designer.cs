
namespace personeltakip
{
    partial class MesaiEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesaiEkleme));
            this.label2 = new System.Windows.Forms.Label();
            this.txtbirimücrt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.maskbaslama = new System.Windows.Forms.MaskedTextBox();
            this.maskbitis = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.combcalisan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttoplamücrt = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.combay = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.combyil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(332, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 1);
            this.label2.TabIndex = 14;
            // 
            // txtbirimücrt
            // 
            this.txtbirimücrt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbirimücrt.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtbirimücrt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbirimücrt.Location = new System.Drawing.Point(332, 261);
            this.txtbirimücrt.Multiline = true;
            this.txtbirimücrt.Name = "txtbirimücrt";
            this.txtbirimücrt.Size = new System.Drawing.Size(200, 33);
            this.txtbirimücrt.TabIndex = 13;
            this.txtbirimücrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbirimücrt.TextChanged += new System.EventHandler(this.txtbirimücrt_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(169, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Birim Ücret:";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(170, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Bitiş:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(170, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 33);
            this.button3.TabIndex = 16;
            this.button3.Text = "Başlama:";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(169, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 33);
            this.button4.TabIndex = 17;
            this.button4.Text = "Çalışan:";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // maskbaslama
            // 
            this.maskbaslama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskbaslama.Location = new System.Drawing.Point(455, 152);
            this.maskbaslama.Mask = "90:00";
            this.maskbaslama.Name = "maskbaslama";
            this.maskbaslama.Size = new System.Drawing.Size(56, 23);
            this.maskbaslama.TabIndex = 18;
            this.maskbaslama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskbaslama.ValidatingType = typeof(System.DateTime);
            // 
            // maskbitis
            // 
            this.maskbitis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskbitis.Location = new System.Drawing.Point(455, 211);
            this.maskbitis.Mask = "90:00";
            this.maskbitis.Name = "maskbitis";
            this.maskbitis.Size = new System.Drawing.Size(56, 23);
            this.maskbitis.TabIndex = 19;
            this.maskbitis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskbitis.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(333, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(93, 23);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.UseWaitCursor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(333, 211);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(93, 23);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // combcalisan
            // 
            this.combcalisan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combcalisan.FormattingEnabled = true;
            this.combcalisan.Location = new System.Drawing.Point(333, 100);
            this.combcalisan.Name = "combcalisan";
            this.combcalisan.Size = new System.Drawing.Size(200, 23);
            this.combcalisan.TabIndex = 22;
            this.combcalisan.SelectedIndexChanged += new System.EventHandler(this.combcalisan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(333, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 1);
            this.label1.TabIndex = 25;
            // 
            // txttoplamücrt
            // 
            this.txttoplamücrt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttoplamücrt.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txttoplamücrt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttoplamücrt.Location = new System.Drawing.Point(333, 318);
            this.txttoplamücrt.Multiline = true;
            this.txttoplamücrt.Name = "txttoplamücrt";
            this.txttoplamücrt.Size = new System.Drawing.Size(200, 33);
            this.txttoplamücrt.TabIndex = 24;
            this.txttoplamücrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttoplamücrt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttoplamücrt_KeyPress);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(170, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 33);
            this.button5.TabIndex = 23;
            this.button5.Text = "Toplam Ücret:";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // combay
            // 
            this.combay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combay.FormattingEnabled = true;
            this.combay.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.combay.Location = new System.Drawing.Point(333, 380);
            this.combay.Name = "combay";
            this.combay.Size = new System.Drawing.Size(104, 23);
            this.combay.TabIndex = 27;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(170, 373);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 33);
            this.button6.TabIndex = 26;
            this.button6.Text = "Dönem:";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // combyil
            // 
            this.combyil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combyil.FormattingEnabled = true;
            this.combyil.Items.AddRange(new object[] {
            "2021",
            "2020"});
            this.combyil.Location = new System.Drawing.Point(466, 379);
            this.combyil.Name = "combyil";
            this.combyil.Size = new System.Drawing.Size(85, 23);
            this.combyil.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(443, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "-";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(354, 442);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(90, 75);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(641, 442);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(539, 102);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 15);
            this.label.TabIndex = 32;
            // 
            // MesaiEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(754, 565);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combyil);
            this.Controls.Add(this.combay);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttoplamücrt);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.combcalisan);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.maskbitis);
            this.Controls.Add(this.maskbaslama);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbirimücrt);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MesaiEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MesaiEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbirimücrt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox maskbaslama;
        private System.Windows.Forms.MaskedTextBox maskbitis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox combcalisan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttoplamücrt;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox combay;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox combyil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
    }
}