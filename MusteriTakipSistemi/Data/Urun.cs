using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakipSistemi.Data
{
    public class Urun
    {
        public int Id { get; set; }

        [Column("Ürün Adı")]
        public string Ad { get; set; } = null!;

        [Precision(18, 2)]
        public decimal Fiyat { get; set; }

        public List<Musteri> Musteriler { get; set; } = new();

        public override string ToString()
        {
            return Ad;
        }
    }
}
