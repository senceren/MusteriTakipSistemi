using Microsoft.EntityFrameworkCore;
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
        List<Musteri> eklenenler = new List<Musteri>();
        bool closeButtonClicked = false; // listeye eklenen müşteriler kaydet ve çık butonuna basarsa müsteriler db'ye aktarılacak.
        Musteri yeniMusteri;

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

            yeniMusteri = new Musteri() { Ad = ad, Soyad = soyad, Telefon = tel, Sehir = sehir, SatinAlmaTarihi = tarih };

            db.Musteriler.Add(yeniMusteri);
            db.SaveChanges();
            MessageBox.Show("Müşteri başarıyla eklenmiştir.");


            eklenenler.Add(yeniMusteri);
            cboMusteriler.DataSource = eklenenler.ToList();

        }

        private void MusterileriListele()
        {

            dgvMusteriler.DataSource = new List<Musteri> { yeniMusteri };
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count < 0)
                return;

            Musteri secili = (Musteri)dgvMusteriler.SelectedRows[0].DataBoundItem;
            db.Musteriler.Remove(secili);

            MessageBox.Show("Müşteri başarıyla silinmiştir.");
            eklenenler.Remove(secili);
            dgvMusteriler.DataSource = new List<Musteri> { yeniMusteri };

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

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Musteri musteri = (Musteri)cboMusteriler.SelectedItem;
            Urun urun = (Urun)cboUrunler.SelectedItem;

            musteri.Urunler.Add(urun);
            db.SaveChanges();
            dgvMusteriler.DataSource = new List<Musteri> { yeniMusteri };

        }

        private void MusteriEklemeForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            //if (!closeButtonClicked)
            //{
            //    DialogResult result = MessageBox.Show("Müşterileri kaydetmeden çıkıyorsunuz.Emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //    if (result == DialogResult.Cancel)
            //    {
            //        e.Cancel = true;
            //    }

            //}

        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Musteri secili = (Musteri)dgvMusteriler.SelectedRows[0].DataBoundItem;
            txtAd.Text = secili.Ad;
            txtSoyad.Text = secili.Soyad;
            txtCepNo.Text = secili.Telefon;
            cboSehirler.SelectedItem = secili.Sehir;
        }
    }
}
