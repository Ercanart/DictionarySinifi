using System;
using System.Collections.Generic;

namespace DictionarySinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> gitaristler = new MyDictionary<string, int>();
            //Generic yapısının çalışma şekli nasıldır?(MyDictionary<string, int>) (1)
            //Çalışılacak veri tiplerini Generic class olan,
            //MyDictionary nin yanına yazdık.(2)
            gitaristler.Add("Jimi Hendrix", 1942);
            gitaristler.Add("Jason Becker", 1969);
            gitaristler.Add("Eddie Van Halen", 1955);
            gitaristler.Add("Anthony Frank Iommi", 1948);



            gitaristler.List();

        }


    }
}
