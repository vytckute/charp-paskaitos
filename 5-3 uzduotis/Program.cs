using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a < 0) {
                Console.WriteLine("Klaida. Ivedete neigiama skaiciu");
            }
            if (a > 0)
            {
                Console.WriteLine("Teisingai. Ivedete teigiama skaiciu");
            }
            if (a%2 ==0)
            {
                Console.WriteLine("Ivestas lyginis skaicius");
            }
            if (a % 4 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 4");
            }
            if (a >10 )
            {
                Console.WriteLine("Skaicius didesnis uz 10");
            }
        }
    }
}
