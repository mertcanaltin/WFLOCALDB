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
    public partial class ryMusteriUrunStokHareketForm : Form
    {
        public ryMusteriUrunStokHareketForm()
        {
            InitializeComponent();
        }
        #region Kullanıcı Tanımlı Metodlar
        private void veriDoldur()
        {
            string sorgu = "SELECT islemTarihi, alinanMiktar, alisFiyati, alisTutari" +
                " FROM STOKHAREKET WHERE urunKodu='" + tbUrunKod.Text + "'";
            dgvUrunListe.DataSource = vtIslem.veriGetir(sorgu);
        }

        private void baslikGoster()
        {
            dgvUrunListe.Columns[0].HeaderText = "İşlem Tarihi";
            dgvUrunListe.Columns[0].Width = 120;
            dgvUrunListe.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvUrunListe.Columns[0].DefaultCellStyle.Format = "d";
            dgvUrunListe.Columns[1].HeaderText = "Miktar";
            dgvUrunListe.Columns[1].Width = 60;
            dgvUrunListe.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvUrunListe.Columns[2].HeaderText = "Alış Fiyatı";
            dgvUrunListe.Columns[2].Width = 120;
            dgvUrunListe.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvUrunListe.Columns[2].DefaultCellStyle.Format = "C2";
            dgvUrunListe.Columns[3].HeaderText = "Alış Tutarı";
            dgvUrunListe.Columns[3].Width = 120;
            dgvUrunListe.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvUrunListe.Columns[3].DefaultCellStyle.Format = "C2";
            dgvUrunListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvUrunListe.RowTemplate.Height = 30;
        }

        private void baslat()
        {
            veriDoldur();
            baslikGoster();
        }
        #endregion
        #region Nesne Tanımlı Metodlar
        private void ryMusteriUrunStokHareketForm_Load(object sender, EventArgs e)
        {
            baslat();
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
