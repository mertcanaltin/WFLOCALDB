namespace ryMusteri
{
    partial class ryMusteriRaporForm
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
            this.raporGoster = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnAnaForm = new System.Windows.Forms.Button();
            this.cmbRaporTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // raporGoster
            // 
            this.raporGoster.ActiveViewIndex = -1;
            this.raporGoster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.raporGoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.raporGoster.Cursor = System.Windows.Forms.Cursors.Default;
            this.raporGoster.Location = new System.Drawing.Point(2, 44);
            this.raporGoster.Name = "raporGoster";
            this.raporGoster.ShowCloseButton = false;
            this.raporGoster.ShowCopyButton = false;
            this.raporGoster.ShowGroupTreeButton = false;
            this.raporGoster.ShowLogo = false;
            this.raporGoster.ShowParameterPanelButton = false;
            this.raporGoster.ShowTextSearchButton = false;
            this.raporGoster.ShowZoomButton = false;
            this.raporGoster.Size = new System.Drawing.Size(927, 498);
            this.raporGoster.TabIndex = 0;
            this.raporGoster.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnAnaForm
            // 
            this.btnAnaForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnaForm.BackgroundImage = global::ryMusteri.Properties.Resources.anaform;
            this.btnAnaForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnaForm.Location = new System.Drawing.Point(893, 2);
            this.btnAnaForm.Name = "btnAnaForm";
            this.btnAnaForm.Size = new System.Drawing.Size(36, 36);
            this.btnAnaForm.TabIndex = 9;
            this.btnAnaForm.UseVisualStyleBackColor = true;
            // 
            // cmbRaporTuru
            // 
            this.cmbRaporTuru.FormattingEnabled = true;
            this.cmbRaporTuru.Items.AddRange(new object[] {
            "Müşteri",
            "Ürün"});
            this.cmbRaporTuru.Location = new System.Drawing.Point(111, 9);
            this.cmbRaporTuru.Name = "cmbRaporTuru";
            this.cmbRaporTuru.Size = new System.Drawing.Size(147, 24);
            this.cmbRaporTuru.TabIndex = 10;
            this.cmbRaporTuru.SelectedIndexChanged += new System.EventHandler(this.cmbRaporTuru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rapor Türü :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ryMusteriRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 542);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRaporTuru);
            this.Controls.Add(this.btnAnaForm);
            this.Controls.Add(this.raporGoster);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "ryMusteriRaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBS - RAPOR";
            this.Load += new System.EventHandler(this.ryMusteriRaporForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer raporGoster;
        private System.Windows.Forms.Button btnAnaForm;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbRaporTuru;
    }
}