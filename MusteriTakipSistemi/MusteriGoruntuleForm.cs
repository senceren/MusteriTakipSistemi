using Microsoft.EntityFrameworkCore;
using MusteriTakipSistemi.Data;
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
    public partial class MusteriGoruntuleForm : Form
    {
        MusteriContext db = new MusteriContext();
        public MusteriGoruntuleForm()
        {
            InitializeComponent();
            MusterileriListele();
        }

        private void MusterileriListele()
        {
            dgvMusteriler.DataSource = db.Musteriler.Include(x => x.Urunler).ToList().SelectMany(m => m.Urunler.Select(u => new
            {
                MusteriAd = m.Ad,
                MusteriSoyad = m.Soyad,
                Urun = u.Ad,
                UrunFiyat = u.Fiyat

            })).ToList();
        }
    }
}
