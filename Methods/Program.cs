using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Elma";
            urun1.UrunFiyati = 10;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Karpuz";
            urun2.UrunFiyati = 35;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)              //Urun yerine var yazsan da olur.
            {
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.UrunFiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");

            }
            Console.WriteLine("--------------------------------------------------------------");

            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil",12);
        }
    }
}
