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
    public partial class ryMusteriAnaForm : Form
    {
        public ryMusteriEkleForm yeniMusteri;
        public ryMusteriUrunTanimiForm urunler;
        public ryMusteriRaporForm rapor;
        public ryMusteriSatisForm satis;
        public ryMusteriGuncelleForm guncelle;
        public ryMusteriHareketForm hareket;
        public ryMusteriAnaForm()
        {
            InitializeComponent();
        }

        #region Tanımlama ve Değişkenler
        public string musteriNo;

        #endregion

        #region Kullanıcı Tanımlı Metodlar
        
        private void veriDoldur()
        {
            string sorgu = "SELECT musteriNo, sirketTanimi, " +
                "yetkiliAdi, yetkiliSoyadi, sirketAdresi, telefonNo " +
                "FROM kimlik";
            dgvMusteriListe.DataSource = vtIslem.veriGetir(sorgu);
        }
        private void baslikGoster()
        {
            dgvMusteriListe.Columns[0].HeaderText = "Müşteri No";
            dgvMusteriListe.Columns[0].Width = 100;
            dgvMusteriListe.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvMusteriListe.Columns[1].HeaderText = "Şirket Bilgisi";
            dgvMusteriListe.Columns[1].Width = 320;
            dgvMusteriListe.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgvMusteriListe.Columns[2].HeaderText = "Yetkili Adı";
            dgvMusteriListe.Columns[2].Width = 120;
            dgvMusteriListe.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgvMusteriListe.Columns[3].HeaderText = "Yetkili Soyadı";
            dgvMusteriListe.Columns[3].Width = 120;
            dgvMusteriListe.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgvMusteriListe.Columns[4].HeaderText = "Şirket Adresi";
            dgvMusteriListe.Columns[4].Width = 320;
            dgvMusteriListe.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgvMusteriListe.Columns[5].HeaderText = "Telefon No";
            dgvMusteriListe.Columns[5].Width = 100;
            dgvMusteriListe.Columns[5].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            dgvMusteriListe.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect;
            dgvMusteriListe.RowTemplate.Height = 30;
        }
        private void baslat()
        {
            veriDoldur();
            baslikGoster();
        }
        private void satisSil()
        {
            string sorgu = "SELECT musteriNo, sirketTanimi, urunKodu, " +
                "urunTanimi, satisMiktari, satisTutari, odemeTuru FROM " +
                "satis WHERE musteriNo='" + musteriNo + "'";
            DataTable satisTablo = vtIslem.veriGetir(sorgu);
            for (int k = 0; k < satisTablo.Rows.Count; k++)
            {
                sorgu = "INSERT INTO satissil (musteriNo, sirketTanimi, "
                    + "urunKodu, urunTanimi, satisMiktari, satisTutari, " +
                    "odemeTuru) VALUES ('"
                    + satisTablo.Rows[k].ItemArray[0].ToString() + "','"
                    + satisTablo.Rows[k].ItemArray[1].ToString() + "','"
                    + satisTablo.Rows[k].ItemArray[2].ToString() + "','"
                    + satisTablo.Rows[k].ItemArray[3].ToString() + "','"
                    + satisTablo.Rows[k].ItemArray[4].ToString() + "','"
                    + satisTablo.Rows[k].ItemArray[5].ToString() + "','"
                    + satisTablo.Rows[k].ItemArray[6].ToString() + "')";
                vtIslem.komutCalistir(sorgu);
            }
        }

        #endregion

        #region Nesene Tanımlı Metodlar
        private void ryMusteriAnaForm_Load(object sender, EventArgs e)
        {
            baslat();
        }
        private void yeniMenuItem_Click(object sender, EventArgs e)
        {
            ryMusteriEkleForm yeniMusteri = new ryMusteriEkleForm();
            yeniMusteri.ShowDialog();
            veriDoldur();
        }
        private void urunlerMenuItem_Click(object sender, EventArgs e)
        {
            urunler = new ryMusteriUrunTanimiForm();
            urunler.ShowDialog();
        }
        private void musteriListeMenuItem_Click(object sender, EventArgs e)
        {
            rapor = new ryMusteriRaporForm();
            rapor.raporTuru = "musteri";
            rapor.ShowDialog();
        }
        private void urunListeMenuItem_Click(object sender, EventArgs e)
        {
            rapor = new ryMusteriRaporForm();
            rapor.raporTuru = "urun";
            rapor.ShowDialog();
        }
        private void tbSirketBilgi_TextChanged(object sender, EventArgs e)
        {
            if (tbSirketBilgi.Text.Trim() == "")
                veriDoldur();
            else
            {
                string sorgu = "SELECT musteriNo, sirketTanimi, yetkiliAdi, "
                    + "yetkiliSoyadi, sirketAdresi, telefonNo FROM kimlik  "
                    + "WHERE sirketTanimi LIKE '%" + tbSirketBilgi.Text + "%'";
                dgvMusteriListe.DataSource = vtIslem.veriGetir(sorgu);
            }
        }
        private void tbYetkiliAd_TextChanged(object sender, EventArgs e)
        {
            if (tbYetkiliAd.Text.Trim() == "")
                veriDoldur();
            else
            {
                string sorgu = "SELECT musteriNo, sirketTanimi, yetkiliAdi,"
                    + " yetkiliSoyadi, sirketAdresi, telefonNo FROM kimlik  "
                    + "WHERE  yetkiliAdi LIKE '%" + tbYetkiliAd.Text + "%'";
                dgvMusteriListe.DataSource = vtIslem.veriGetir(sorgu);
            }
        }
        private void satisYapMenuItem_Click(object sender, EventArgs e)
        {
            satis = new ryMusteriSatisForm();
            satis.tbMusteriNo.Text =
                    dgvMusteriListe.CurrentRow.Cells[0].Value.ToString();
            satis.tbSirketBilgi.Text =
                    dgvMusteriListe.CurrentRow.Cells[1].Value.ToString();
            satis.ShowDialog();
        }     
        private void guncelleMenuItem_Click(object sender, EventArgs e)
        {
            guncelle = new ryMusteriGuncelleForm();
            guncelle.tbMusteriNo.Text =
                dgvMusteriListe.CurrentRow.Cells[0].Value.ToString();
            guncelle.tbMusteriNo.Enabled = false;
            guncelle.tbSirketBilgi.Text =
                dgvMusteriListe.CurrentRow.Cells[1].Value.ToString();
            guncelle.tbYetkiliAd.Text =
                dgvMusteriListe.CurrentRow.Cells[2].Value.ToString();
            guncelle.tbYetkiliSoyad.Text =
                dgvMusteriListe.CurrentRow.Cells[3].Value.ToString();
            guncelle.tbAdres.Text =
                dgvMusteriListe.CurrentRow.Cells[4].Value.ToString();
            guncelle.tbTelefonNo.Text =
                dgvMusteriListe.CurrentRow.Cells[5].Value.ToString();
            guncelle.ShowDialog();
            veriDoldur();
        }
        private void silMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Müşteriyi Silmek istiyor musunuz",
                "Bilgi", MessageBoxButtons.YesNo,MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                musteriNo =
                    dgvMusteriListe.CurrentRow.Cells[0].Value.ToString();
                string sorgu = "INSERT INTO kimliksil (musteriNo, " +
                        " sirketTanimi, yetkiliAdi, yetkiliSoyadi, sirketAdresi, " +
                        "telefonNo ) VALUES ('"
                        + dgvMusteriListe.CurrentRow.Cells[0].Value.ToString() + "','"
                        + dgvMusteriListe.CurrentRow.Cells[1].Value.ToString() + "','"
                        + dgvMusteriListe.CurrentRow.Cells[2].Value.ToString() + "','"
                        + dgvMusteriListe.CurrentRow.Cells[3].Value.ToString() + "','"
                        + dgvMusteriListe.CurrentRow.Cells[4].Value.ToString() + "','"
                        + dgvMusteriListe.CurrentRow.Cells[5].Value.ToString() + "')";
                vtIslem.komutCalistir(sorgu);
                satisSil();
                sorgu = "DELETE FROM kimlik WHERE musteriNo='"
                    + musteriNo + "'";
                vtIslem.komutCalistir(sorgu);
                sorgu = "DELETE FROM satis WHERE musteriNo='"
                    + musteriNo + "'";
                vtIslem.komutCalistir(sorgu);
                MessageBox.Show("Seçili Müşteri Bilgileri Silindi", "Bilgi",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                veriDoldur();
            }
        }
        private void hareketlerMenuItem_Click(object sender, EventArgs e)
        {
            hareket = new ryMusteriHareketForm();
            hareket.tbMusteriNo.Text =
                dgvMusteriListe.CurrentRow.Cells[0].Value.ToString();
            hareket.tbSirketBilgi.Text =
                dgvMusteriListe.CurrentRow.Cells[1].Value.ToString();
            hareket.ShowDialog();
        }
        private void raporSatisMenuItem_Click(object sender, EventArgs e)
        {
            rapor = new ryMusteriRaporForm();
            rapor.musteriNo =
                dgvMusteriListe.CurrentRow.Cells[0].Value.ToString();
            rapor.cmbRaporTuru.Enabled = false;
            rapor.ShowDialog();
            rapor.cmbRaporTuru.Enabled = true;
        }
        private void kapatMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istiyor musunuz?", "Bilgi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes) Application.Exit();
        }
        #endregion
    }
}
