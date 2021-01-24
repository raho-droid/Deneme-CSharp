using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Engin";
            musteri1.MusteriSoyadi = "Demiroğ";
            musteri1.MusteriYasi = 30;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Ali";
            musteri2.MusteriSoyadi = "Yılmaz";
            musteri2.MusteriYasi = 42;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Halloldu");
            }
            MusteriManager.Sil(musteri2);
        }
    }
}
