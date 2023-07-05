using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakipSistemi.Data
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public int SehirId { get; set; }
        public Sehir Sehir { get; set; } = null!;

        [Column("Satın Alma Tarihi")]
        public DateTime SatinAlmaTarihi { get; set; }
        public List<Urun> Urunler { get; set; } = new();

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
