using MusteriTakipSistemi.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakipSistemi
{
    public partial class MusteriEklemeForm : Form
    {
        MusteriContext db = new MusteriContext();
        List<Musteri> yeniMusteriler = new List<Musteri>();
        public MusteriEklemeForm()
        {
            InitializeComponent();
            SehirleriListele();
            UrunleriListele();
        }

        private void UrunleriListele()
        {
            cboUrunler.DataSource = db.Urunler.ToList();
        }

        private void SehirleriListele()
        {
            cboSehirler.DataSource = db.Sehirler.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string tel = txtCepNo.Text;
            Sehir sehir = (Sehir)cboSehirler.SelectedItem;
            DateTime tarih = dtpTarih.Value;

            Musteri yeniMusteri = new Musteri() { Ad = ad, Soyad = soyad, Telefon = tel, Sehir = sehir, SatinAlmaTarihi = tarih };


            // yeni bir müşteri dizisi oluşturduk. eğer kaydet ve çık tuşuna basılırsa bu listeyi komple db ye aktaracağız.
            yeniMusteriler.Add(yeniMusteri);

            MessageBox.Show("Müşteri başarıyla eklenmiştir.");
            cboMusteriler.DataSource = yeniMusteriler.ToList();

        }

        private void MusterileriListele()
        {
            dgvMusteriler.DataSource = yeniMusteriler.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count < 0)
                return;

            Musteri secili = (Musteri)dgvMusteriler.SelectedRows[0].DataBoundItem;
            yeniMusteriler.Remove(secili);
            MessageBox.Show("Müşteri başarıyla silinmiştir.");
            MusterileriListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count < 0)
                return;

            Musteri guncellenecek = (Musteri)dgvMusteriler.SelectedRows[0].DataBoundItem;

            guncellenecek.Ad = txtAd.Text;
            guncellenecek.Soyad = txtSoyad.Text;
            guncellenecek.Telefon = txtCepNo.Text;
            guncellenecek.SatinAlmaTarihi = dtpTarih.Value;
            guncellenecek.Sehir = (Sehir)cboSehirler.SelectedItem;

            MusterileriListele();

        }

        private void btnKaydetVeCik_Click(object sender, EventArgs e)
        {
            db.Musteriler.AddRange(yeniMusteriler);
            db.SaveChanges();
            // form kapansın
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = (Musteri)cboMusteriler.SelectedItem;
            Urun urun = (Urun)cboUrunler.SelectedItem;

            musteri.Urunler.Add(urun);
            MusterileriListele();
        }

        private void dgvMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Musteri secili = (Musteri)dgvMusteriler.SelectedRows[0].DataBoundItem;
            secili.Ad = txtAd.Text;
            secili.Soyad = txtSoyad.Text;
            secili.Telefon = txtCepNo.Text;
            secili.Sehir = (Sehir)cboSehirler.SelectedItem;
            
            
        }
    }
}
