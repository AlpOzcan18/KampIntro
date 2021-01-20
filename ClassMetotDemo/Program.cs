using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 25525454;
            musteri1.Adi = "Zeynep";
            musteri1.Soyadi = "RECEP";
            musteri1.Yasi = 21;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 25524545;
            musteri2.Adi = "Alp Özcan";
            musteri2.Soyadi = "RECEP";
            musteri2.Yasi = 22;
            
            
            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);

            musterimanager.Sil(musteri1);
            musterimanager.Sil(musteri2);

            
            
            musterimanager.Listele(musteri1);
            musterimanager.Listele(musteri2);






        }
    }
}
