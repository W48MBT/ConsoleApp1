using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için temel Kurs ";
            string kurs3 = "Java Kursu ";
            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Programlamaya Başlangıç için temel Kurs ", "Java Kursu "," Pyhton ","C#"};
            //array :diziler
            
            Console.WriteLine("DÖNGÜLER");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("FOR DÖNGÜSÜ BİTTİ FOREACH?");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("SAYFA SONU (footer)");
        }
    }
}
