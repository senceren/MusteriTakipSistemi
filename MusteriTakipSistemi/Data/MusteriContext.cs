using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakipSistemi.Data
{
    public class MusteriContext : DbContext
    {
        public DbSet<Musteri> Musteriler => Set<Musteri>();
        public DbSet<Urun> Urunler => Set<Urun>();
        public DbSet<Sehir> Sehirler => Set<Sehir>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localDB)\MSSQLLocalDB;database=ArsumMusteriDb; trusted_connection=true;");
        }
    }
}
