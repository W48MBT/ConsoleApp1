using System;

namespace W48
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety : tip güvenliği
            // do not repeat yourself :kendini tekrarlama
            //değer tutucu alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool SistemeGirisYapmismi = true ;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (SistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {

            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
