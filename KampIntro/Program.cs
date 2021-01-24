using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //Do not repeat yourself
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Ayarlar Butonu ");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }
           
          //  Console.WriteLine(kategoriEtiketi);
        }
    }
}
