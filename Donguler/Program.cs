using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Kampi";
            string kurs2 = "Programlama Baslangic İcin Temel Kurs";
            string kurs3 = "Java";

            //array = dizi

            string[] kurslar = new string[] { "Yazilim Gelistirici Kampi", "Programlama Baslangic İcin Temel Kurs", "Java" };


            for (int i = 0; i<kurslar.Length; i++)  //i+=2   //i++ //i=i+1
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }



    }
}
