using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seçili kısma ctrl k + ctrl c yapınca yorum satırı olur. ctrl k + ctrl u yorumu kaldırır.

            //    asdbfjkhabsdfhsndfnsadkfjnaljsdhfjlshdfjhsdnkfansldfasldfasdfasdm
            //    dsafsadljfkasdfjsdajfkasdjfsadf
            //    fasdsadfasdfsdfasdfasdfasd
            //    asdfasdfasdfasdfsdfsdafasdfasd

            //Diziler dinamik yapıda değildir. Yani en baştaki eleman sayısı dışında eleman ekleyemeyiz. O yüzden koleksiyon kullanılır.

            List<string> isimler2 = new List<string>() {"Engin","Murat","Kerem","Halil" };
            Console.WriteLine(isimler2[0]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[4]);

        }
    }
}
