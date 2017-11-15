using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            var c = Convert.ToInt32(Console.ReadLine());
           double  vidurkis = ((double)a + b + c) / 3;
            Console.WriteLine("Skaiciu {0},{1},{2} vidurkis yra {3}", a, b, c, Math.Round(vidurkis,2));
        }
    }
}
