using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items; // Burda zaten biz T ye string dedik bunuda metodun dısında yaparız yani classın içinde her metot erişsin diye
        //consturctor
        public MyList()
        {
            items = new T[0];   
        }

          
     public void Add(T item)
        {

            T[] tempArray = items; 
            items = new T[items.Length + 1]; //üste dizim 0 elemanlı benim bunu artırmam lazım o yüzden lenght dedim

            for (int i = 0; i < tempArray.Length; i++) // Döngü ile tempArray'e veri verdik onları geri alıcaz döngü ile
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //son elemeanı aldık
        }
    }
}














/*Genercis class demek özel bir tip olacağını belirtmek demek<T> T=Type'den gelir burda diyor ki ben Generic te T ile çalışmak
 istiyorum */

// Burda T belirtmemizin sebebi diyorki programcı orda bana hangi tip verirse versin fark etmez

// T[] istems: altına ctor tab tab yaparsak consturctor açılır bir class çalıştığında new'lenen bloğa constructor denir


/*   T[] tempArray = items; dememizin sebebi new dediğimizde tüm referans tipleri gider gitmemesi için bir biziye attık yani
 ben bir eleman eklersem dolaysıyla yine Lenght+1 diyecem o yüzden tekrar new'lediğimde diğer elemanlarım kaybolmasın diye yani
geçici diziye bunları tut ben yeni bir dizi eklicem kaybolmasın diye */   

