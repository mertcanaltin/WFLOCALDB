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
    public partial class ryMusteriEkleForm : Form
    {
        public ryMusteriEkleForm()
        {
            InitializeComponent();
        }
        #region Tanımlamalar ve Değişkenler
        bool dolumu = false;
        #endregion
        #region Kullanıcı Tanımlaı Metodlar
        private void kontrol()
        {
            for (int k = 0; k < Controls.Count; k++)
                if (Controls[k] is TextBox)
                {
                    if (Controls[k].Text.Trim() != "")
                        dolumu = true;
                    else
                    {
                        dolumu = false;
                        break;
                    }
                }
            tbMusteriNo.Select();
        }
        private void temizle()
        {
            for (int k = 0; k < Controls.Count; k++)
                if (Controls[k] is TextBox)
                    Controls[k].Text = "";
        }

        #endregion
        #region Nesne Tanımlı Metodlar
        private void ryMusteriEkleForm_Load(object sender, EventArgs e)
        {
            tbMusteriNo.Select();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kontrol();
            if (dolumu)
            {
                string sorgu = "INSERT INTO kimlik (musteriNo, " +
                    "sirketTanimi, yetkiliAdi, yetkiliSoyadi, sirketAdresi, " +
                    "telefonNo ) VALUES ('"+tbMusteriNo.Text+"','"
                    +tbSirketBilgi.Text+"','"+tbYetkiliAd.Text+"','"
                    +tbYetkiliSoyad.Text+"','"+tbAdres.Text+"','"
                    +tbTelefonNo.Text+"')";
                vtIslem.komutCalistir(sorgu);
                MessageBox.Show("Yeni Müşteri Oluşturuldu!", "Bilgi",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else
            {
                MessageBox.Show("Alanları boş bırakmayınız", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMusteriNo.Select();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion        
    }
}
