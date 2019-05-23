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
    public partial class ryMusteriHareketForm : Form
    {
        public ryMusteriHareketForm()
        {
            InitializeComponent();
        }
        #region Tanımlamalar ve Değişkenler

        #endregion
        #region Kullanıcı Tanımlı Metodlar
        private void veriDoldur()
        {
            string musStr = "SELECT urunKodu, urunTanimi, satisMiktari," +
                   "satisTutari,odemeTuru FROM satis WHERE musteriNo='"
                   + tbMusteriNo.Text + "'";
            dgvSatisListe.DataSource = vtIslem.veriGetir(musStr);
        }

        private void baslikGoster()
        {
            dgvSatisListe.Columns[0].HeaderText = "Ürün Kodu";
            dgvSatisListe.Columns[0].Width = 80;
            dgvSatisListe.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvSatisListe.Columns[1].HeaderText = "Ürün Bilgisi";
            dgvSatisListe.Columns[1].Width = 300;
            dgvSatisListe.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgvSatisListe.Columns[2].HeaderText = "Miktar";
            dgvSatisListe.Columns[2].Width = 60;
            dgvSatisListe.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvSatisListe.Columns[3].HeaderText = "Satış Tutarı";
            dgvSatisListe.Columns[3].Width = 120;
            dgvSatisListe.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvSatisListe.Columns[3].DefaultCellStyle.Format = "C2";
            dgvSatisListe.Columns[4].HeaderText = "Ödeme Türü";
            dgvSatisListe.Columns[4].Width = 120;
            dgvSatisListe.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }

        private void baslat()
        {
            veriDoldur();
            baslikGoster();
        }

        #endregion
        #region Nesne Tanımlı Metodlar
        private void ryMusteriHareketForm_Load(object sender, EventArgs e)
        {
            baslat();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
