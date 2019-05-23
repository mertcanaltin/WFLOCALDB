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
    public partial class ryMusteriSatisForm : Form
    {
        public ryMusteriUrunStokForm stok;
        public ryMusteriSatisForm()
        {
            InitializeComponent();
        }
        #region Tanımlamalar ve Değişkenler
        DataTable musTablo = new DataTable();
        DataTable odemeTablo = new DataTable();
        string sorgu = "";
        int stokMiktari;
        #endregion
        #region Kullanıcı Tanımlaı Metodlar
        private void veriDoldur()
        {
            musTablo.Clear();
            sorgu = "SELECT urunKodu, urunTanimi, urunMiktari, " +
                           "satisFiyati FROM urunler";
            musTablo = vtIslem.veriGetir(sorgu);
            dgvUrunListe.DataSource = musTablo;
        }

        private void odemeDoldur()
        {
            odemeTablo.Clear();
            sorgu = "SELECT odemeTuru FROM odeme";
            odemeTablo = vtIslem.veriGetir(sorgu);
            int k = 0;
            while (k < odemeTablo.Rows.Count)
            {
                cmbOdeme.Items.Add
            (odemeTablo.Rows[k].ItemArray[0].ToString());
                k++;
            }
        }

        private void baslikGoster()
        {
            dgvUrunListe.Columns[0].HeaderText = "Ürün Kodu";
            dgvUrunListe.Columns[0].Width = 80;
            dgvUrunListe.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvUrunListe.Columns[1].HeaderText = "Ürün Tanimi";
            dgvUrunListe.Columns[1].Width = 300;
            dgvUrunListe.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgvUrunListe.Columns[2].HeaderText = "Miktar";
            dgvUrunListe.Columns[2].Width = 60;
            dgvUrunListe.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvUrunListe.Columns[3].HeaderText = "Satış Fiyatı";
            dgvUrunListe.Columns[3].Width = 120;
            dgvUrunListe.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvUrunListe.Columns[3].DefaultCellStyle.Format = "C2";
        }

        private void baslat()
        {
            odemeDoldur();
            veriDoldur();
            baslikGoster();
        }

        #endregion
        #region Nesne Tanımlı Metodlar
        private void ryMusteriSatisForm_Load(object sender, EventArgs e)
        {
            baslat();
        }
        private void satisYapMenuItem_Click(object sender, EventArgs e)
        {
            tbUrunKodu.Text =
                    dgvUrunListe.CurrentRow.Cells[0].Value.ToString();
            tbUrunTanimi.Text =
                    dgvUrunListe.CurrentRow.Cells[1].Value.ToString();
            tbSatisFiyat.Text =
                    dgvUrunListe.CurrentRow.Cells[3].Value.ToString();
            stokMiktari = Convert.ToInt16
                    (dgvUrunListe.CurrentRow.Cells[2].Value.ToString());
            tbMiktar.Select();
        }
        private void tbMiktar_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int satisMiktari = Convert.ToInt16(tbMiktar.Text);
                if (satisMiktari <= stokMiktari)
                {
                    tbSatisTutari.Text = (Convert.ToDouble
                        (tbSatisFiyat.Text) * satisMiktari).ToString();
                    cmbOdeme.Select();
                }
                else
                {
                    MessageBox.Show("Yeterli Stok Yok!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbUrunKodu.Clear();
                    tbUrunTanimi.Clear();
                    tbSatisFiyat.Clear();
                    tbMiktar.Clear();
                    cmbOdeme.Text = "Seçiniz";
                    tbMiktar.Select();
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Dikkat",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void stokEkleMenuItem_Click(object sender, EventArgs e)
        {
            stok = new ryMusteriUrunStokForm();
            stok.tbUrunKodu.Text =
                    dgvUrunListe.CurrentRow.Cells[0].Value.ToString();
            stok.tbUrunTanimi.Text =
                    dgvUrunListe.CurrentRow.Cells[1].Value.ToString();
            stok.ShowDialog();
            veriDoldur();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sorgu = "INSERT INTO satis(musteriNo,sirketTanimi,urunKodu,"
                + "urunTanimi, satisMiktari,satisTutari,odemeTuru) " +
                " VALUES('" + tbMusteriNo.Text + "','" + tbSirketBilgi.Text +
                "','" + tbUrunKodu.Text + "','" + tbUrunTanimi.Text +
                "','" + tbMiktar.Text + "','" + tbSatisTutari.Text +
                "','" + cmbOdeme.Text + "')";
            vtIslem.komutCalistir(sorgu);
            sorgu = "UPDATE urunler SET urunMiktari=urunMiktari-'"
                    + Convert.ToInt16(tbMiktar.Text) + "'  WHERE urunKodu='"
                    + tbUrunKodu.Text + "'";
            vtIslem.komutCalistir(sorgu);
            veriDoldur();
            tbUrunKodu.Clear();
            tbUrunTanimi.Clear();
            tbSatisTutari.Clear();
            tbSatisFiyat.Clear();
            tbMiktar.Clear();
            tbMiktar.Select();
            cmbOdeme.Text = "Seçiniz";
        }       

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion        
    }
}
