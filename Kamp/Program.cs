using System;

namespace Kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım geliştirme Kampı", "CSS kampı","React Kampı",
            "JavaScript Kampı"};

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs); // Tek tek arar bulur bulur dizileri 
            }
        }
    }
}
