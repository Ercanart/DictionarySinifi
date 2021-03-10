using System;
using System.Collections.Generic;
using System.Text;

namespace DictionarySinifi
{
    class MyDictionary<A, D>
    //Generic class : Çalışmak istenilen veri tipi, o an programcı 
    //new lediğinde hangi tipi seçerse, o olacaktır,(<A, D>).(--1.Adım--)
    {
        A[] akeys;
        D[] dkeys;
        //Metodun dışında başka metotlardan da erişebilmek için
        //yeni arraylar oluşturduk.(--2.Adım--)
        //Constructor
        public MyDictionary() //ctor + tabx2 yapıp Constructor oluşturduk.(--3.Adım--)

        {

            akeys = new A[0];
            dkeys = new D[0];
            //classlar new lendiğinde constructor otomatik çalışır.akeys ve dkeys arraylarını new
            //lediğimizde sıfır elemanlı arraylar oluşturduk.(--4.Adım--)
        }
        public void Add(A akey, D dkey)
        {
            A[] atempArray = akeys;
            //5.Adımda akeys array inin 1 arttırmak için new lediğimizde,
            //yeni referans numarası aldığı için, önceki referans numarası gider.
            //Bu nedenle akeys de ki referans numarasını başka bir array e yedekleriz.
            //(A[] dtempArray = akeys;) (--6.Adım--)
            akeys = new A[akeys.Length + 1];
            //Dizilere eleman ekleyebilmek için, akeys ve dkeys dizilerinde,
            //eleman sayısını bir arttırmak gerekiyor.
            //Bunun için dizileri new ledik.(akeys = new A[akeys.Length + 1];) (--5.Adım--)


            D[] dtempArray = dkeys;
            //5.Adımda dkeys array inin 1 arttırmak için new lediğimizde,
            //yeni referans numarası aldığı için, önceki referans numarası gider.
            //Bu nedenle dkeys de ki referans numarasını başka bir array e yedekleriz.
            //(D[] dtempArray = dkeys;) (--6.Adım--)
            dkeys = new D[dkeys.Length + 1];
            //Dizilere eleman ekleyebilmek için, akeys ve dkeys dizilerinde,
            //eleman sayısını bir arttırmak gerekiyor.
            //Bunun için dizileri new ledik.(dkeys = new D[akeys.Length + 1];) (--5.Adım--)

            for (int i = 0; i < atempArray.Length; i++)
            //6.Adımda atemparray da yedeklediğimiz akeys ve dkeys array lerinin
            //elemanlarını geri çağırmak için for döngüsü oluşturduk.(--7.Adım--)

            {
                akeys[i] = atempArray[i];
                dkeys[i] = dtempArray[i];
                //.atempArray in bütün elemanlarını tekrar akeys e ve dkeys e
                //atıyoruz.Bunun için dtempArray i de kullanabilirdik,
                //fark etmiyor.(--8.Adım--)
                //Bu noktada dtempArray için ayrı bir for döngüsü oluşturmaya gerek kalmadı.
                //Çünkü döngü, [i] inci eleman sayısına göre çalışyor ve ayrıca akeys ve dkeys 
                //array lerinin eleman sayısı da aynıdır.Bu nedenle (dkeys[i] = dtempArray[i];)
                //(dkeys[i] = dtempArray[i];) Eşitlemesi ile dkeys array ini de,
                //döngüye dahil etmiş olduk.


            }

            akeys[akeys.Length - 1] = akey;
            dkeys[dkeys.Length - 1] = dkey;
            //Sonunda yeni eklenen son elemanı, akey e ve dkey e -- Add(A akey, D dkey) --
            //eklemek için, akeys ve dkeys array lerinin son elemanlarını atıyoruz.(--9.Adım--)
            //[akeys.Length - 1];Örneğin akeys.Length 6 elemanlı olarak,
            //son elemanı(6.elemanı) ekleyecekse, 6 - 1 = 5 i bulacaktır.
            //Sayım 0,1,2,3,4,5 olarak yapılacağından,
            //zaten 5.eleman, 6.eleman olacaktır.




        }

        public void List() //Buradaki for döngüsünü de, eklenen elemanları
                           //listelemek için metot olarak kullanabiliriz.(--10.Adım)
        {
            for (int i = 0; i < akeys.Length; i++)
            {
                Console.WriteLine(akeys[i] + " " + dkeys[i]);

            }
        }









    }
}
