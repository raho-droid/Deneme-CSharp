﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi  :  " + urun.UrunAdi);


        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine(urunAdi);
        }
    }
}
