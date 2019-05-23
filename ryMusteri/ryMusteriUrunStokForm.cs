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
    public partial class ryMusteriUrunStokForm : Form
    {
        public ryMusteriUrunStokForm()
        {
            InitializeComponent();
        }

        #region Nesne Bağlantılı Olaylar
        private void ryMusteriUrunStokForm_Load(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = false;
            tbMiktar.Select();
        }
        private void tbAlisFiyat_Validating(object sender, CancelEventArgs e)
        {
            if (tbMiktar.Text.Trim() != "" && tbAlisFiyat.Text.Trim() != "")
            {
                tbSatisFiyat.Text = ((Convert.ToDouble(tbAlisFiyat.Text) * 1.20) * 1.18).ToString("###");
                btnGuncelle.Enabled = true;
                btnGuncelle.Select();
            }
            else
            {
                MessageBox.Show("Alanları boş bırakmayınız", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMiktar.Select();
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE urunler SET urunMiktari=urunMiktari+'"
                + Convert.ToInt16(tbMiktar.Text) + "', alisFiyati='" + tbAlisFiyat.Text +
                "', satisFiyati='" + tbSatisFiyat.Text + "' WHERE urunKodu='"
                + tbUrunKodu.Text + "'";
            vtIslem.komutCalistir(sorgu);
            sorgu = "INSERT INTO stokhareket (urunKodu, islemTarihi," +
                "alinanMiktar,alisFiyati,alisTutari) VALUES ('" + tbUrunKodu.Text +
                "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tbMiktar.Text +
                "','" + Convert.ToInt16(tbAlisFiyat.Text) + "','" + (Convert.ToInt16(tbMiktar.Text) *
                Convert.ToDouble(tbAlisFiyat.Text)) + "')";
            vtIslem.komutCalistir(sorgu);
            btnGuncelle.Enabled = false;
            tbMiktar.Clear();
            tbAlisFiyat.Clear();
            tbSatisFiyat.Clear();
            this.Close();
        }
        #endregion
    }
}
