using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string>isimler = new MyList<string>();
            isimler.Add("Nurselam");

           
        }
    }
}


// Burda Generics'e string verdik int de verebilirdik. Biz string belirtiğimiz için arka planda yani MyListe T string oluyor
// Bu string yerine class'da olabilirdi