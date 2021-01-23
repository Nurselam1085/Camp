using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.Izlenme = 2000;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JavaScript";
            kurs2.Egitmen = "Volkan Alakent";
            kurs2.Izlenme = 1000;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "CSS";
            kurs3.Egitmen = "Süleyman Şeker";
            kurs3.Izlenme = 1500;

            Kurs[] kursalar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kursalar)
            {
                Console.WriteLine("Kurs Adı :" +  kurs.KursAdi);
                Console.WriteLine("Kurs Eğitmeni:" + kurs.Egitmen);
                Console.WriteLine("Kurs İzlenme Sayısı:" + kurs.Izlenme);

            }






            //Console.WriteLine(kurs1.Egitmen);




        }


        class Kurs
        {
            public string KursAdi { get; set; }

            public string Egitmen { get; set; }

            public int Izlenme { get; set; }
        }



    }
}
