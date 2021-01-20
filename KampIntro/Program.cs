using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayısı = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmısMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            if (sistemeGirisYapmısMi == true)
            {
                Console.WriteLine("Kullanici ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            Console.WriteLine(kategoriEtiketi);

            {

            }
        }
    }
}

