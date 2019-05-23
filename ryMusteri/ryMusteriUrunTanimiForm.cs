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
    public partial class ryMusteriUrunTanimiForm : Form
    {
        public ryMusteriUrunStokHareketForm hareket;
        public ryMusteriRaporForm rapor;
        public ryMusteriUrunTanimiForm()
        {
            InitializeComponent();
        }

        #region Tanımlamalar ve Değişkenler
        bool dolumu = true;
        string urunKodu;
        #endregion
        #region Kullanıcı Tanımlı Metodlar
        private void kontrol()
        {
            for (int k = 0; k < Controls.Count; k++)
                if (Controls[k] is TextBox)
                    if (Controls[k].Text.Trim() == "")
                    {
                        dolumu = false;
                        break;
                    }
        }
        private void temizle()
        {
            for (int k = 0; k < Controls.Count; k++)
                if (Controls[k] is TextBox)
                    Controls[k].Text = "";
            tbUrunKodu.Select();
        }
        private void veriDoldur()
        {
            string musStr = "SELECT urunKodu,urunTanimi,urunMiktari," +
                                   "alisFiyati,satisFiyati FROM urunler";
            dgvUrunListe.DataSource = vtIslem.veriGetir(musStr);
        }
        private void baslikGoster()
        {
            dgvUrunListe.Columns[0].HeaderText = "Ürün Kodu";
            dgvUrunListe.Columns[0].Width = 80;
            dgvUrunListe.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvUrunListe.Columns[1].HeaderText = "Ürün Bilgisi";
            dgvUrunListe.Columns[1].Width = 300;
            dgvUrunListe.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgvUrunListe.Columns[2].HeaderText = "Miktar";
            dgvUrunListe.Columns[2].Width = 60;
            dgvUrunListe.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvUrunListe.Columns[3].HeaderText = "Alış Fiyatı";
            dgvUrunListe.Columns[3].Width = 120;
            dgvUrunListe.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvUrunListe.Columns[3].DefaultCellStyle.Format = "C2";
            dgvUrunListe.Columns[4].HeaderText = "Satış Fiyatı";
            dgvUrunListe.Columns[4].Width = 120;
            dgvUrunListe.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvUrunListe.Columns[4].DefaultCellStyle.Format = "C2";
        }
        private void baslat()
        {
            btnGuncelle.Enabled = false;
            veriDoldur();
            baslikGoster();
            tbUrunKodu.Select();
        }
        private void stokHareketSil()
        {
            DataTable stokTablo = new DataTable();
            string musStr = "SELECT urunKodu,islemTarihi,alinanMiktar,"
                + "alisFiyati,alisTutari  FROM stokhareket WHERE " 
                +"urunKodu='" + urunKodu + "'";
            stokTablo = vtIslem.veriGetir(musStr);
            for (int k = 0; k < stokTablo.Rows.Count; k++)
            {
                musStr = "INSERT INTO stokhareketsil (urunKodu," +
                    "islemTarihi,alinanMiktar,alisFiyati,alisTutari) VALUES ('"
                    + stokTablo.Rows[k].ItemArray[0].ToString() + "','"
                    + stokTablo.Rows[k].ItemArray[1].ToString() + "','"
                    + stokTablo.Rows[k].ItemArray[2].ToString() + "','"
                    + stokTablo.Rows[k].ItemArray[3].ToString() + "','"
                    + stokTablo.Rows[k].ItemArray[4].ToString() + "')";
                vtIslem.komutCalistir(musStr);
            }
        }

        #endregion
        #region Nesne Tanımlı Metodlar
        private void ryMusteriUrunTanimiForm_Load(object sender, EventArgs e)
        {
            baslat();
        }
        private void tbAlisFiyat_Validating(object sender, CancelEventArgs e)
        {
            if (tbAlisFiyat.Text.Trim() != "")
            {
                tbSatisFiyat.Text =
                    ((Convert.ToDouble(tbAlisFiyat.Text) * 1.20)*1.18).ToString("###");
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kontrol();
            if (dolumu)
            {
                string musStr = "INSERT INTO urunler (urunKodu," +
                    "urunTanimi,urunMiktari,alisFiyati,satisFiyati) VALUES ('"
                    + tbUrunKodu.Text + "','" + tbUrunTanimi.Text + "','"
                    + tbMiktar.Text + "','" + tbAlisFiyat.Text + "','"
                    + tbSatisFiyat.Text + "')";
                vtIslem.komutCalistir(musStr);
                double alisTutari = (Convert.ToDouble(tbAlisFiyat.Text) *
                    Convert.ToDouble(tbMiktar.Text));
                musStr = "INSERT INTO stokhareket (urunKodu," +
                    "islemTarihi,alinanMiktar,alisFiyati,alisTutari) VALUES ('"
                    + tbUrunKodu.Text + "','" + DateTime.Now.ToString
                    ("MM.dd.yyyy") + "','" + tbMiktar.Text + "','"
                    + tbAlisFiyat.Text + "','" + alisTutari.ToString() + "')";
                vtIslem.komutCalistir(musStr);
                veriDoldur();
                MessageBox.Show("Yeni Ürün Oluşturuldu!", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else
            {
                MessageBox.Show("Alanlar Boş Kalmasın!", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUrunKodu.Select();
            }

        }

        private void guncelleMenuItem_Click(object sender, EventArgs e)
        {
            tbUrunKodu.Enabled = false;
            tbUrunKodu.Text =
                    dgvUrunListe.CurrentRow.Cells[0].Value.ToString();
            tbUrunTanimi.Text =
                    dgvUrunListe.CurrentRow.Cells[1].Value.ToString();
            tbMiktar.Text =
                    dgvUrunListe.CurrentRow.Cells[2].Value.ToString();
            tbAlisFiyat.Text =
                    dgvUrunListe.CurrentRow.Cells[3].Value.ToString();
            tbSatisFiyat.Text =
                    dgvUrunListe.CurrentRow.Cells[4].Value.ToString();
            btnGuncelle.Enabled = true;
            btnKaydet.Enabled = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kontrol();
            if (dolumu)
            {
                string musStr = "UPDATE urunler SET urunTanimi='"
                    + tbUrunTanimi.Text + "',urunMiktari=urunMiktari+'"
                    + tbMiktar.Text + "',alisFiyati='" + tbAlisFiyat.Text +
                    "',satisFiyati='" + tbSatisFiyat.Text +
                    "' WHERE urunKodu='" + tbUrunKodu.Text + "'";
                vtIslem.komutCalistir(musStr);
                musStr = "INSERT INTO stokhareket (urunKodu," +
                    "islemTarihi,alinanMiktar,alisFiyati,alisTutari) VALUES ('"
                    + tbUrunKodu.Text + "','" + DateTime.Now.ToString
                    ("MM.dd.yyyy") + "','" + tbMiktar.Text + "','" + tbAlisFiyat.Text
                    + "','" + (Convert.ToDouble(tbAlisFiyat.Text) *
                    (Convert.ToDouble(tbMiktar.Text))) + "')";
                vtIslem.komutCalistir(musStr);
                veriDoldur();
                MessageBox.Show("Ürün Güncellemesi Yapıldı!", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUrunKodu.Enabled = true;
                temizle();
            }
            else
            {
                MessageBox.Show("Alanlar Boş Kalmasın!", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUrunKodu.Select();
            }

        }

        private void silMenuItem_Click(object sender, EventArgs e)
        {
            urunKodu =
                    dgvUrunListe.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show ("Seçili olan Ürünü \nsilmek istiyor musunuz?", 
                "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
            {
                string musStr = "INSERT INTO urunlersil (urunKodu," +
                    "urunTanimi,urunMiktari,alisFiyati,satisFiyati) VALUES ('"
                    + dgvUrunListe.CurrentRow.Cells[0].Value.ToString() + "','"
                    + dgvUrunListe.CurrentRow.Cells[1].Value.ToString() + "','"
                    + dgvUrunListe.CurrentRow.Cells[2].Value.ToString() + "','"
                    + dgvUrunListe.CurrentRow.Cells[3].Value.ToString() + "','"
                    + dgvUrunListe.CurrentRow.Cells[4].Value.ToString() + "')";
                vtIslem.komutCalistir(musStr);
                stokHareketSil();
                musStr = "DELETE  FROM urunler WHERE urunKodu='"
                                + urunKodu + "'";
                vtIslem.komutCalistir(musStr);
                musStr = "DELETE  FROM stokhareket WHERE urunKodu='"
                                + urunKodu + "'";
                vtIslem.komutCalistir(musStr);
                veriDoldur();
            }
        }

        private void hareketlerMenuItem_Click(object sender, EventArgs e)
        {
            hareket = new ryMusteriUrunStokHareketForm();
            hareket.tbUrunKod.Text =
                    dgvUrunListe.CurrentRow.Cells[0].Value.ToString();
            hareket.tbUrunBilgisi.Text =
                    dgvUrunListe.CurrentRow.Cells[1].Value.ToString();
            hareket.ShowDialog();
        }
        private void raporMenuItem_Click(object sender, EventArgs e)
        {
            rapor = new ryMusteriRaporForm();
            rapor.urunKodu =
                    dgvUrunListe.CurrentRow.Cells[0].Value.ToString();
            rapor.cmbRaporTuru.Enabled = false;
            rapor.raporTuru = "";
            rapor.ShowDialog();
            rapor.cmbRaporTuru.Enabled = true;
        }
        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
