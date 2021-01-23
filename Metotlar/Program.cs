using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Açiklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 55;
            urun2.Açiklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach ( var urun in urunler)
            {
                Console.WriteLine("Ürünün adi:" + urun.Adi);
                Console.WriteLine("Ürünün Fiyatı:" + urun.Fiyati);
                Console.WriteLine("Ürünün Açıklması:" + urun.Açiklama);
                Console.WriteLine("---------------------");

            }

            Console.WriteLine("---Metodlar--------------");


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", "");

        }
    }
}







// Metodalar tekrar tekrar kulanabilirlik açısında önemlidir.
// Kodlama temel yapısı class'lar dır.