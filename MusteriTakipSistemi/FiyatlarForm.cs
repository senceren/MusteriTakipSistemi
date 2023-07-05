using MusteriTakipSistemi.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakipSistemi
{
    public partial class FiyatlarForm : Form
    {
        MusteriContext db = new MusteriContext();
        public FiyatlarForm()
        {
            InitializeComponent();
            UrunleriListele();
        }

        private void UrunleriListele()
        {

            dgvUrunler.DataSource = db.Urunler.ToList();

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {


                string urunAd = txtUrunAdi.Text;
                decimal urunFiyat = Convert.ToInt64(txtUrunFiyati.Text);

                Urun yeniUrun = new Urun() { Ad = urunAd, Fiyat = urunFiyat };
                db.Urunler.Add(yeniUrun);
                db.SaveChanges();
                MessageBox.Show("Ürün başarıyla eklenmiştir.");
                UrunleriListele();
                txtUrunAdi.Clear();
                txtUrunFiyati.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün fiyatını giriniz.");
            }

        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count < 0)
                return;

            Urun guncellenecek = (Urun)dgvUrunler.SelectedRows[0].DataBoundItem;

            guncellenecek.Ad = txtUrunAdi.Text;
            guncellenecek.Fiyat = Convert.ToInt64(txtUrunFiyati.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellenmiştir.");
            UrunleriListele();
            txtUrunAdi.Clear();
            txtUrunFiyati.Clear();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count < 0)
                return;

            Urun silinecek = (Urun)dgvUrunler.SelectedRows[0].DataBoundItem;
            db.Urunler.Remove(silinecek);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla silinmiştir.");
            UrunleriListele();
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Urun urun = (Urun)dgvUrunler.SelectedRows[0].DataBoundItem;

            txtUrunAdi.Text = urun.Ad;
            txtUrunFiyati.Text = urun.Fiyat.ToString();
        }
    }
}
