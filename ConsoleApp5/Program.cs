using System;

namespace ConsoleApp5
{
    string adi = "Abdulkadir"
    int yas = 10;

    Kurs kurs1 = new Kurs();
    kurs1.KursAdi = "C#";
    kurs1.Egitmeni = "Engin";
    kurs1.IzlenmeOrani = 94;

    Kurs kurs2 = new Kurs();
    kurs2.KursAdi = "Java";
    kurs2.Egitmeni = "Ali";
    kurs2.IzlenmeOrani = 96;

    Kurs kurs3 = new Kurs();
    kurs3.KursAdi = "pyton";
    kurs3.Egitmeni = "Veli";
    kurs3.IzlenmeOrani = 91;

    Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

    foreach (var kurs in kurslar)
    {
      Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);
    }



  }
    class Kurs

    pulic string KursAdi { get; set; }
pulic string Egitmeni { get; set; }
pulic string IzlenmeOrani { get; set; }   
    }
}
