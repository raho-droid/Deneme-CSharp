using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri Musteri)
        {
            Console.WriteLine("Musteri eklenmistir...");
        }
        public void Listele(Musteri Musteri)
        {
            Console.WriteLine("Musteriler");
        }
        public void Sil(Musteri Musteri)
        {
            Console.WriteLine(Musteri+" silindi...");
        }
    }
}
