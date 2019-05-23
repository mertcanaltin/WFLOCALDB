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
    public partial class ryMusteriRaporForm : Form
    {
        public ryMusteriRaporForm()
        {
            InitializeComponent();
        }

        #region Tanımlamaşlar ve Değişkenler
        public string musteriNo;
        public string urunKodu;
        public string raporTuru;
        #endregion
        #region Kullanıcı Tanımlı Metodlar
        private void musteri()
        {
            string sorgu = "SELECT musteriNo,sirketTanimi, sirketAdresi,telefonNo " +
                "FROM kimlik";
            ryRaporMusteriListe rapor = new ryRaporMusteriListe();
            rapor.SetDataSource(vtIslem.veriGetir(sorgu));
            raporGoster.ReportSource = rapor;
        }
        private void urun()
        {
            string sorgu = "SELECT urunKodu,urunTanimi,urunMiktari, satisFiyati" +
                "  FROM urunler";
            ryRaporUrunListe rapor = new ryRaporUrunListe();
            rapor.SetDataSource(vtIslem.veriGetir(sorgu));
            raporGoster.ReportSource = rapor;
        }

        private void satisDoldur()
        {
            string sorgu = "SELECT musteriNo,sirketTanimi,urunKodu,urunTanimi," +
                "satisMiktari, satisTutari  FROM satis WHERE musteriNo='" + musteriNo + "'";
            ryRaporMusteriSatisListe rapor = new ryRaporMusteriSatisListe();
            rapor.SetDataSource(vtIslem.veriGetir(sorgu));
            raporGoster.ReportSource = rapor;
        }
        private void stokDoldur()
        {
            string sorgu = "SELECT urunKodu, islemTarihi, alinanMiktar,alisFiyati, alisTutari " +
                "FROM stokhareket WHERE urunKodu='" + urunKodu + "'";
            ryRaporUrunStokListe rapor = new ryRaporUrunStokListe();
            rapor.SetDataSource(vtIslem.veriGetir(sorgu));
            raporGoster.ReportSource = rapor;
        }
        #endregion

        #region Nesne Bağlantılı Metodlar
        private void ryMusteriRaporForm_Load(object sender, EventArgs e)
        {
            if (raporTuru == "musteri")
            {
                musteri();
            }
            else if (raporTuru == "urun")
            {
                urun();
            }
            else if (musteriNo != null)
            {
                satisDoldur();
            }
            else if (urunKodu != null)
            {
                stokDoldur();
            }
        }
        private void cmbRaporTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRaporTuru.SelectedIndex == 0)
            {
                musteri();
            }
            if (cmbRaporTuru.SelectedIndex == 1)
            {
                urun();
            }
        }
        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            musteriNo = null;
            urunKodu = null;
            this.Close();
        }
        #endregion
    }
}
