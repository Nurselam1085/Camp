using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        
      public void Ekle(Urun urun) // Metodu şu şekilde yazıyoruz
        {

            Console.WriteLine("Sepete eklendi : " + urun.Adi);
            Console.WriteLine("Ürünün fiyatı : " + urun.Fiyati);
        }

       
    }
}

// İsimlendirme baş harf büyük olsun rahat okunsun
