namespace ryMusteri
{
    partial class ryMusteriGuncelleForm
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
            this.tbTelefonNo = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbYetkiliSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbYetkiliAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSirketBilgi = new System.Windows.Forms.TextBox();
            this.tbMusteriNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTelefonNo
            // 
            this.tbTelefonNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTelefonNo.Location = new System.Drawing.Point(129, 289);
            this.tbTelefonNo.MaxLength = 10;
            this.tbTelefonNo.Name = "tbTelefonNo";
            this.tbTelefonNo.Size = new System.Drawing.Size(126, 24);
            this.tbTelefonNo.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::ryMusteri.Properties.Resources.guncel;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(277, 279);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(36, 36);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = global::ryMusteri.Properties.Resources.anaform;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Location = new System.Drawing.Point(277, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(36, 36);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(12, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Telefon No :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAdres
            // 
            this.tbAdres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAdres.Location = new System.Drawing.Point(129, 204);
            this.tbAdres.MaxLength = 150;
            this.tbAdres.Multiline = true;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(184, 69);
            this.tbAdres.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Şirket Adresi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbYetkiliSoyad
            // 
            this.tbYetkiliSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbYetkiliSoyad.Location = new System.Drawing.Point(129, 166);
            this.tbYetkiliSoyad.MaxLength = 20;
            this.tbYetkiliSoyad.Name = "tbYetkiliSoyad";
            this.tbYetkiliSoyad.Size = new System.Drawing.Size(184, 24);
            this.tbYetkiliSoyad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Yetkili Soyadi:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbYetkiliAd
            // 
            this.tbYetkiliAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbYetkiliAd.Location = new System.Drawing.Point(129, 128);
            this.tbYetkiliAd.MaxLength = 20;
            this.tbYetkiliAd.Name = "tbYetkiliAd";
            this.tbYetkiliAd.Size = new System.Drawing.Size(184, 24);
            this.tbYetkiliAd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Yetkili Adi :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSirketBilgi
            // 
            this.tbSirketBilgi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSirketBilgi.Location = new System.Drawing.Point(129, 46);
            this.tbSirketBilgi.MaxLength = 150;
            this.tbSirketBilgi.Multiline = true;
            this.tbSirketBilgi.Name = "tbSirketBilgi";
            this.tbSirketBilgi.Size = new System.Drawing.Size(184, 69);
            this.tbSirketBilgi.TabIndex = 1;
            // 
            // tbMusteriNo
            // 
            this.tbMusteriNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMusteriNo.Enabled = false;
            this.tbMusteriNo.Location = new System.Drawing.Point(129, 9);
            this.tbMusteriNo.MaxLength = 8;
            this.tbMusteriNo.Name = "tbMusteriNo";
            this.tbMusteriNo.Size = new System.Drawing.Size(100, 24);
            this.tbMusteriNo.TabIndex = 0;
            this.tbMusteriNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Şirket Bilgisi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Müşteri No :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ryMusteriGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 327);
            this.ControlBox = false;
            this.Controls.Add(this.tbTelefonNo);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbYetkiliSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbYetkiliAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSirketBilgi);
            this.Controls.Add(this.tbMusteriNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ryMusteriGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBS - GÜNCELLEME";
            this.Load += new System.EventHandler(this.ryMusteriGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbTelefonNo;
        public System.Windows.Forms.TextBox tbAdres;
        public System.Windows.Forms.TextBox tbYetkiliSoyad;
        public System.Windows.Forms.TextBox tbYetkiliAd;
        public System.Windows.Forms.TextBox tbSirketBilgi;
        public System.Windows.Forms.TextBox tbMusteriNo;
    }
}