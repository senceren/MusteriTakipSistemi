using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriTakipSistemi.Data
{
    public class MusteriContextSeed
    {
        public static void Seed()
        {
            using (var db = new MusteriContext())
            {
                if (db.Urunler.Any() || db.Sehirler.Any())
                    return;

                var sehirler = new Sehir[]
                {
                   new Sehir {Ad = "Adana"},
                   new Sehir {Ad = "Adıyaman"},
                   new Sehir {Ad = "Afyonkarahisar"},
                   new Sehir {Ad = "Ağrı"},
                   new Sehir {Ad = "Amasya"},
                   new Sehir {Ad = "Ankara"},
                   new Sehir {Ad = "Antalya"},
                   new Sehir {Ad = "Artvin"},
                   new Sehir {Ad = "Aydın"},
                   new Sehir {Ad = "Balıkesir"},
                   new Sehir {Ad = "Bilecik"},
                   new Sehir {Ad = "Bingöl"},
                   new Sehir {Ad = "Bitlis"},
                   new Sehir {Ad = "Bolu"},
                   new Sehir {Ad = "Burdur"},
                   new Sehir {Ad = "Bursa"},
                   new Sehir {Ad = "Çanakkale"},
                   new Sehir {Ad = "Çankırı"},
                   new Sehir {Ad = "Çorum"},
                   new Sehir {Ad = "Denizli"},
                   new Sehir {Ad = "Diyarbakır"},
                   new Sehir {Ad = "Edirne"},
                   new Sehir {Ad = "Elazığ"},
                   new Sehir {Ad = "Erzincan"},
                   new Sehir {Ad = "Erzurum"},
                   new Sehir {Ad = "Eskişehir"},
                   new Sehir {Ad = "Gaziantep"},
                   new Sehir {Ad = "Giresun"},
                   new Sehir {Ad = "Gümüşhane"},
                   new Sehir {Ad = "Hakkari"},
                   new Sehir {Ad = "Hatay"},
                   new Sehir {Ad = "Isparta"},
                   new Sehir {Ad = "Mersin"},
                   new Sehir {Ad = "İstanbul"},
                   new Sehir {Ad = "İzmir"},
                   new Sehir {Ad = "Kars"},
                   new Sehir {Ad = "Kastamonu"},
                   new Sehir {Ad = "Kayseri"},
                   new Sehir {Ad = "Kırklareli"},
                   new Sehir {Ad = "Kırşehir"},
                   new Sehir {Ad = "Kocaeli"},
                   new Sehir {Ad = "Konya"},
                   new Sehir {Ad = "Kütahya"},
                   new Sehir {Ad = "Malatya"},
                   new Sehir {Ad = "Manisa"},
                   new Sehir {Ad = "Kahramanmaraş"},
                   new Sehir {Ad = "Mardin"},
                   new Sehir {Ad = "Muğla"},
                   new Sehir {Ad = "Muş"},
                   new Sehir {Ad = "Nevşehir"},
                   new Sehir {Ad = "Niğde"},
                   new Sehir {Ad = "Ordu"},
                   new Sehir {Ad = "Rize"},
                   new Sehir {Ad = "Sakarya"},
                   new Sehir {Ad = "Samsun"},
                   new Sehir {Ad = "Siirt"},
                   new Sehir {Ad = "Sinop"},
                   new Sehir {Ad = "Sivas"},
                   new Sehir {Ad = "Tekirdağ"},
                   new Sehir {Ad = "Tokat"},
                   new Sehir {Ad = "Trabzon"},
                   new Sehir {Ad = "Tunceli"},
                   new Sehir {Ad = "Şanlıurfa"},
                   new Sehir {Ad = "Uşak"},
                   new Sehir {Ad = "Van"},
                   new Sehir {Ad = "Yozgat"},
                   new Sehir {Ad = "Zonguldak"},
                   new Sehir {Ad = "Aksaray"},
                   new Sehir {Ad = "Bayburt"},
                   new Sehir {Ad = "Karaman"},
                   new Sehir {Ad = "Kırıkkale"},
                   new Sehir {Ad = "Batman"},
                   new Sehir {Ad = "Şırnak"},
                   new Sehir {Ad = "Bartın"},
                   new Sehir {Ad = "Ardahan"},
                   new Sehir {Ad = "Iğdır"},
                   new Sehir {Ad = "Yalova"},
                   new Sehir {Ad = "Karabük"},
                   new Sehir {Ad = "Kilis"},
                   new Sehir {Ad = "Osmaniye"},
                   new Sehir {Ad = "Düzce"}

                };

                db.AddRange(sehirler);
                db.SaveChanges();

                var urunler = new Urun[]
                {
                   new Urun() {Ad = "Arsum Premix 1 Lt",Fiyat = 100.00m},
                   new Urun() {Ad = "Arsum Premix 5 Lt",Fiyat = 430.00m},
                   new Urun() {Ad = "Arsum Varroclean 500 ml",Fiyat = 70.00m},
                   new Urun() {Ad = "Arsum Varroclean 5 Lt",Fiyat = 480.00m,},
                   new Urun() {Ad = "Polen Temizleme Makinesi",Fiyat = 8500.00m},
                   new Urun() {Ad = "Sisleme Makinesi",Fiyat = 5800.00m},
                   new Urun() {Ad = "Perga Makinesi",Fiyat = 7800.00m},
                   new Urun() {Ad = "Arı Sütü Toplama Makinesi",Fiyat = 7000.00m},
                   new Urun() {Ad = "Arı Zehri Toplama Makinesi(Kovan Üzeri)",Fiyat = 7800.00m},
                   new Urun() {Ad = "Arı Zehri Toplama Makinesi(Kovan İçi)",Fiyat = 7800.00m},

                };

                db.AddRange(urunler);
                db.SaveChanges();
            }


        }

    }
}
