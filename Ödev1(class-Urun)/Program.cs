using System;

namespace Ödev1_class_Urun_
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Deterjan";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Tişört";

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Parfüm";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
            }
        }
    }
    class Urun
    {
        public string UrunAdi;
        
    }
}
