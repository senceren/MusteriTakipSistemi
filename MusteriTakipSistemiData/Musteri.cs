namespace MusteriTakipSistemiData
{
    public class Musteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TelefonNo { get; set; }
        public string Sehir { get; set; }
        public Urun Urun { get; set; }
    }
}