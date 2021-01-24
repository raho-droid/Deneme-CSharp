using System;

namespace EnginH_Youtube
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 10;
            int number2 = 20;

            var toplam = add(ref number1,number2);          //Bu noktada eğer fonksiyonun içindeki değişimin genele etki etmesini istiyorsak
            Console.WriteLine(toplam);                      //değişkenin başına ref ya da out yazılabilir. Fark ref'te number1'a mutlaka
            Console.WriteLine(number1);                     //veri koyulmalıdır. out'da böyle bir zorunluluk yoktur.

            Console.WriteLine(carpma(2,3));
            Console.WriteLine(carpma(2,3,4));


            Console.WriteLine(toplama(3,4,5,6,7,8));

        }
        static int add(ref int number1, int number2)
        {
            number1 = 31;
            return number1 + number2;
        }
        static int carpma(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }
        static int carpma(int sayi1,int sayi2,int sayi3)        //İsimleri aynı olsa bile değişkenler farklı olduğu zaman fomksiyonlar 
        {                                                       //sorunsuz çalışır. Ama bayağı kullanışsızdır çünkü kullanıcı birkaç sayı
            return sayi1 * sayi2 * sayi3;                       //girebilir. Bu yüzden params keywordunu kullanabiliriz.
        }
        static int toplama(params int[] sayilar)
        {
            return sayilar.Sum();                               //Sum() fonksiyonu dizideki elemanları toplar.
        }
    }
}
