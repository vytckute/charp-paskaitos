using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            if (a == b) {
                Console.WriteLine("Pirmas=Antram");
            }
            if (c == b)
            {
                Console.WriteLine("Trecias=Antram");
            }
            if (a>b)
            {
                Console.WriteLine("Pirmas daugiau uz Antras");
            }
            if (b > (2*c))
            {
                Console.WriteLine("antras skaičius yra didesnis už dvigubą trečiojo skaičiaus ");
            }
            if ((a%2)==0)
            {
                Console.WriteLine("pirmas skaičius yra lyginis ");
            }
            if ((b % 2) != 0)
            {
                Console.WriteLine("2 skaičius yra nelyginis ");
            }
            if (c>0)
            {
                Console.WriteLine("trečias skaičius yra teigiamas ");
            }
            if (c < 0)
            {
                Console.WriteLine("trečias skaičius yra neigiamas ");
            }

        }
    }
}
