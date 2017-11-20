using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> skaiciai=new List<int>();
            var rnd = new Random(); //atsitiktiniu skaiciu generavimas
            var kieksugeneruoti = rnd.Next(1, 101); //[1-100] //kiek skaiciu generuosim
            var kiekis = 0;
            var kiekislyginiu = 0;

            for (int i = 0; i < kieksugeneruoti; i++)
            {//generuojam atsitiktini skaiciu ir ji dedam
                skaiciai.Add(rnd.Next(1, 101));
                Console.Write(skaiciai[i]+" "); //isvedam ka tik ideta skaiciu
            }
            Console.WriteLine("Maziausias skaicius: "+skaiciai.Min());
            Console.WriteLine("Didziausias skaicius: "+skaiciai.Max());
            Console.WriteLine("Vidurkis skaicius: " + skaiciai.Average());
            var vidurkis = skaiciai.Average();
            foreach (var skaicius in skaiciai)
            {
                if (skaicius < vidurkis)
                {
                    kiekis ++;
                }
                if (skaicius % 2 == 0)
                {
                    kiekislyginiu++;
                }
            }
            Console.WriteLine("Kiekis skaičių mažesnių už vidurkį "+kiekis);
            Console.WriteLine("Kiekis lyginiu " + kiekislyginiu);
        }
    }
}
