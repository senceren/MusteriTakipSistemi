using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakipSistemi.Data
{
    public class Sehir
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public List<Musteri> Musteriler { get; set; } = new();

        public override string ToString()
        {
            return Ad;
        }

    }
}
