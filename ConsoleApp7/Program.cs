using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdı = "ETİCARET";
            urun1.UrunModel = "ideasoft";
            urun1.UrunFiyatı = 50.00;

            Urun urun2 = new Urun();
            urun2.UrunAdı = "SOSYALMEDYAREKRAMCILIĞI";
            urun2.UrunModel = "ADRES GEZGİNİ";
            urun2.UrunFiyatı = 500.00;

            Urun urun3 = new Urun();
            urun3.UrunAdı = "BARKODLUSATIS";
            urun3.UrunModel = "AFANDA";
            urun3.UrunFiyatı = 150.00;

            Urun urun4 = new Urun();
            urun4.UrunAdı = "YAZILIM";
            urun4.UrunModel = "UYUMSOFT";
            urun4.UrunFiyatı = 3000.00;


            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4 };

            foreach (var urun in urunler)
            {
            Console.WriteLine(Urun.UrunAdı + " , " + Urun.UrunModel + ", " Urun.UrunFiyatı "₺");
            }
         }
    }


    class Urun
        {
            public string UrunAdı { get; set; }
            public string UrunModel { get; set; }
            public double UrunFiyatı { get; set; }
        }
    
}
