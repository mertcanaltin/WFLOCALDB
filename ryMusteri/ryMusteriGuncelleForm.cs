using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ryMusteri
{
    public partial class ryMusteriGuncelleForm : Form
    {
        public ryMusteriGuncelleForm()
        {
            InitializeComponent();
        }

        private void ryMusteriGuncelleForm_Load(object sender, EventArgs e)
        {
            tbSirketBilgi.Select();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE  kimlik SET sirketTanimi='"
                + tbSirketBilgi.Text + "', yetkiliAdi='" + tbYetkiliAd.Text +
                "', yetkiliSoyadi='" + tbYetkiliSoyad.Text + "', sirketAdresi='"
                + tbAdres.Text + "', telefonNo='" + tbTelefonNo.Text +
                "' WHERE musteriNo='" + tbMusteriNo.Text + "'";
            vtIslem.komutCalistir(sorgu);
            MessageBox.Show("Müşteri Bilgileri Güncellendi!", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
