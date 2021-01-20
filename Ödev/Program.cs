using System;

namespace Ödev
{
    class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            urun urun1 = new urun();
            urun1.urunAdi = "Kalem";
            urun1.satici = "Fabel";
            urun1.fiyati = 100;
            urun1.indirim = 5;

            urun urun2 = new urun();
            urun2.urunAdi = "Telefon";
            urun2.satici = "Samsung";
            urun2.fiyati = 1000;
            urun2.indirim = 10;

            urun urun3 = new urun();
            urun3.urunAdi = "Saat";
            urun3.satici = "Casio";
            urun3.fiyati = 500;
            urun3.indirim = 2;


            Console.WriteLine(" For each Döngüsü");

            urun[] urunler = new urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Urun Adı : " + urun.urunAdi);
                Console.WriteLine("Urun Saticisi:" + urun.satici);
                Console.WriteLine("Urun Fiyati :" + urun.fiyati);
                Console.WriteLine("Urun İndirim Oranı :" + urun.indirim);
            }


            Console.WriteLine("  For Döngüsü ");

            urun[] urunlistesi = new urun[] { urun1, urun2, urun3 };

            for (int list = 0; list < urunler.Length; list++)
            {
                Console.WriteLine("Urun Adı : " + urunler[list].urunAdi);
                Console.WriteLine("Urun Saticisi:" + urunler[list].satici);
                Console.WriteLine("Urun Fiyati :" + urunler[list].fiyati);
                Console.WriteLine("Urun İndirim Oranı :" + urunler[list].indirim);
            }
            Console.WriteLine(" While Döngüsü");
            int parameter = 0;
            while (parameter < urunler.Length)
            {
                Console.WriteLine("Urun Adı : " + urunler[parameter].urunAdi);
                Console.WriteLine("Urun Saticisi:" + urunler[parameter].satici);
                Console.WriteLine("Urun Fiyati :" + urunler[parameter].fiyati);
                Console.WriteLine("Urun İndirim Oranı :" + urunler[parameter].indirim);

                parameter++;
            }

        }




    }

    class urun
    {
        public string urunAdi { get; set; }
        public string satici { get; set; }
        public int fiyati { get; set; }
        public int indirim { get; set; }
    }
}