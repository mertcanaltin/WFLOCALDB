namespace ryMusteri
{
    partial class ryMusteriAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.musteriAnaMenu = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunlerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriListeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunListeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbYetkiliAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSirketBilgi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMusteriListe = new System.Windows.Forms.DataGridView();
            this.musteriIslemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.satisYapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.silMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guncelleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hareketlerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.raporSatisMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriAnaMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListe)).BeginInit();
            this.musteriIslemMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriAnaMenu
            // 
            this.musteriAnaMenu.Font = new System.Drawing.Font("Verdana", 10F);
            this.musteriAnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.kapatMenuItem});
            this.musteriAnaMenu.Location = new System.Drawing.Point(0, 0);
            this.musteriAnaMenu.Name = "musteriAnaMenu";
            this.musteriAnaMenu.Size = new System.Drawing.Size(1154, 25);
            this.musteriAnaMenu.TabIndex = 0;
            this.musteriAnaMenu.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMenuItem,
            this.urunlerMenuItem,
            this.raporMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.işlemlerToolStripMenuItem.Text = "&Müşteri";
            // 
            // yeniMenuItem
            // 
            this.yeniMenuItem.Name = "yeniMenuItem";
            this.yeniMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniMenuItem.Text = "Yeni";
            this.yeniMenuItem.Click += new System.EventHandler(this.yeniMenuItem_Click);
            // 
            // urunlerMenuItem
            // 
            this.urunlerMenuItem.Name = "urunlerMenuItem";
            this.urunlerMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunlerMenuItem.Text = "Ürünler";
            this.urunlerMenuItem.Click += new System.EventHandler(this.urunlerMenuItem_Click);
            // 
            // raporMenuItem
            // 
            this.raporMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriListeMenuItem,
            this.urunListeMenuItem});
            this.raporMenuItem.Name = "raporMenuItem";
            this.raporMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raporMenuItem.Text = "Rapor";
            // 
            // musteriListeMenuItem
            // 
            this.musteriListeMenuItem.Name = "musteriListeMenuItem";
            this.musteriListeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.musteriListeMenuItem.Text = "Müşteri Liste";
            this.musteriListeMenuItem.Click += new System.EventHandler(this.musteriListeMenuItem_Click);
            // 
            // urunListeMenuItem
            // 
            this.urunListeMenuItem.Name = "urunListeMenuItem";
            this.urunListeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunListeMenuItem.Text = "Ürün Liste";
            this.urunListeMenuItem.Click += new System.EventHandler(this.urunListeMenuItem_Click);
            // 
            // kapatMenuItem
            // 
            this.kapatMenuItem.Name = "kapatMenuItem";
            this.kapatMenuItem.Size = new System.Drawing.Size(52, 21);
            this.kapatMenuItem.Text = "Çıkış";
            this.kapatMenuItem.Click += new System.EventHandler(this.kapatMenuItem_Click);
            // 
            // tbYetkiliAd
            // 
            this.tbYetkiliAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbYetkiliAd.Location = new System.Drawing.Point(584, 40);
            this.tbYetkiliAd.MaxLength = 20;
            this.tbYetkiliAd.Name = "tbYetkiliAd";
            this.tbYetkiliAd.Size = new System.Drawing.Size(184, 24);
            this.tbYetkiliAd.TabIndex = 19;
            this.tbYetkiliAd.TextChanged += new System.EventHandler(this.tbYetkiliAd_TextChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(467, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Yetkili Adi :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSirketBilgi
            // 
            this.tbSirketBilgi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSirketBilgi.Location = new System.Drawing.Point(129, 39);
            this.tbSirketBilgi.MaxLength = 150;
            this.tbSirketBilgi.Name = "tbSirketBilgi";
            this.tbSirketBilgi.Size = new System.Drawing.Size(319, 24);
            this.tbSirketBilgi.TabIndex = 18;
            this.tbSirketBilgi.TextChanged += new System.EventHandler(this.tbSirketBilgi_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Şirket Bilgisi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvMusteriListe
            // 
            this.dgvMusteriListe.AllowUserToAddRows = false;
            this.dgvMusteriListe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusteriListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMusteriListe.ColumnHeadersHeight = 25;
            this.dgvMusteriListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMusteriListe.Location = new System.Drawing.Point(12, 68);
            this.dgvMusteriListe.Name = "dgvMusteriListe";
            this.dgvMusteriListe.ReadOnly = true;
            this.dgvMusteriListe.RowHeadersWidth = 25;
            this.dgvMusteriListe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvMusteriListe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMusteriListe.RowTemplate.ContextMenuStrip = this.musteriIslemMenu;
            this.dgvMusteriListe.RowTemplate.Height = 25;
            this.dgvMusteriListe.Size = new System.Drawing.Size(1126, 288);
            this.dgvMusteriListe.TabIndex = 20;
            // 
            // musteriIslemMenu
            // 
            this.musteriIslemMenu.Font = new System.Drawing.Font("Verdana", 10F);
            this.musteriIslemMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satisYapMenuItem,
            this.toolStripSeparator2,
            this.silMenuItem,
            this.guncelleMenuItem,
            this.toolStripSeparator1,
            this.hareketlerMenuItem,
            this.toolStripSeparator3,
            this.raporSatisMenuItem});
            this.musteriIslemMenu.Name = "musteriIslemMenu";
            this.musteriIslemMenu.Size = new System.Drawing.Size(148, 132);
            // 
            // satisYapMenuItem
            // 
            this.satisYapMenuItem.Name = "satisYapMenuItem";
            this.satisYapMenuItem.Size = new System.Drawing.Size(147, 22);
            this.satisYapMenuItem.Text = "Satış Yap";
            this.satisYapMenuItem.Click += new System.EventHandler(this.satisYapMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(144, 6);
            // 
            // silMenuItem
            // 
            this.silMenuItem.Name = "silMenuItem";
            this.silMenuItem.Size = new System.Drawing.Size(147, 22);
            this.silMenuItem.Text = "Sil";
            this.silMenuItem.Click += new System.EventHandler(this.silMenuItem_Click);
            // 
            // guncelleMenuItem
            // 
            this.guncelleMenuItem.Name = "guncelleMenuItem";
            this.guncelleMenuItem.Size = new System.Drawing.Size(147, 22);
            this.guncelleMenuItem.Text = "Güncelle";
            this.guncelleMenuItem.Click += new System.EventHandler(this.guncelleMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // hareketlerMenuItem
            // 
            this.hareketlerMenuItem.Name = "hareketlerMenuItem";
            this.hareketlerMenuItem.Size = new System.Drawing.Size(147, 22);
            this.hareketlerMenuItem.Text = "Hareketler";
            this.hareketlerMenuItem.Click += new System.EventHandler(this.hareketlerMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(144, 6);
            // 
            // raporSatisMenuItem
            // 
            this.raporSatisMenuItem.Name = "raporSatisMenuItem";
            this.raporSatisMenuItem.Size = new System.Drawing.Size(147, 22);
            this.raporSatisMenuItem.Text = "Rapor";
            this.raporSatisMenuItem.Click += new System.EventHandler(this.raporSatisMenuItem_Click);
            // 
            // ryMusteriAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 374);
            this.ControlBox = false;
            this.Controls.Add(this.tbYetkiliAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSirketBilgi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMusteriListe);
            this.Controls.Add(this.musteriAnaMenu);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.musteriAnaMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ryMusteriAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ BİLGİ SİSTEMİ";
            this.Load += new System.EventHandler(this.ryMusteriAnaForm_Load);
            this.musteriAnaMenu.ResumeLayout(false);
            this.musteriAnaMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListe)).EndInit();
            this.musteriIslemMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip musteriAnaMenu;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunlerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriListeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunListeMenuItem;
        private System.Windows.Forms.TextBox tbYetkiliAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSirketBilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMusteriListe;
        private System.Windows.Forms.ContextMenuStrip musteriIslemMenu;
        private System.Windows.Forms.ToolStripMenuItem satisYapMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem silMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guncelleMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem hareketlerMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem raporSatisMenuItem;
    }
}
