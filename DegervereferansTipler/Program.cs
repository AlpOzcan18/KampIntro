using System;

namespace DegervereferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            //sayi1 ?? 30

            //array,calss, interface = referans
            //int,decimal,float,double,bool(true,false 0,1)=değer tip

            // stack                                               
            // sayu1= 10 (sayı 1 in değeri 10)
            //sayı2=30 (buralrada tanımlanıyor
            //sayi1=sayi2 (sayi 1 in değeri eşittir sayi 2)
            //sayi1 unutursun ve artık değeri sayi2 olru
            //sen sayi 2 yi değiştirsen de o artık 30 dur
            //65 den etkilenemz

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            //stack                                       heap
            //  101/sayılar1      new(adres oluştur)          101/[10,20,30]                   
            //  102/sayılar2                                   102/[100,200,,300)

            //sayılar 1 in refernas numarası artık sayılar 2 nin referans numarsına eşittir

            //sayılar 2 de 0 inci elemanı değiştirince referasn olduğu için sayılar 1 de 999 olur bunun nedeni referans olmasıdır


        }
    }
}
