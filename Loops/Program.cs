using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazilim kampi";
            string kurs2 = "temel kurs";

            //array - dizi

            string[] kurslar = new string[] { "yazilim kampi", "temel kurs","Java","Python","C++" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for sonu");
            //foreach dizi temelli yapıları tek tek dönmeye yarar.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");


        }
    }
}
