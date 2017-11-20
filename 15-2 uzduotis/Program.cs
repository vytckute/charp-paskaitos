using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var pazymiai = new int[5];
            pazymiai[0] = 5;
            pazymiai[1] = 7;
            pazymiai[2] = 10;
            pazymiai[3] = 9;
            pazymiai[4] = 3;

            var max = 0;
            var kiekis = 0;
            var kiekis2 = 0;
            var suma = 0;
            foreach (var pazy in pazymiai)
            {
                suma += pazy;
                if (pazy > max)
                {
                    max = pazy;
                }
                if (pazy == 10)
                {
                    kiekis += 1;
                }
                if (pazy <4)
                {
                    kiekis2 += 1;
                }
            }

            Console.WriteLine("Geriausias pazymy:s " + max);
            Console.WriteLine("Kiekis 10: " + kiekis);
            Console.WriteLine("Kiekis neigiamu: " + kiekis2);
            Console.WriteLine("Vidurkis: " + ((double)suma/pazymiai.Length));
        }
    }
}
