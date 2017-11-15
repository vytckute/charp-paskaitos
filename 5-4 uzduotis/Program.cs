using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite paskutinius savo 5 pazymius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var d = Convert.ToInt32(Console.ReadLine());
            var e = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (a + b + c + d + e) / 5;
            if (vidurkis >= 5) {
                Console.WriteLine("vidurkis yra lygus arba didesnis už 5.");
            }
        }
    }
}
