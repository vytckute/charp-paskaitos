using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koks jusu vardas?");
            var vardas = Console.ReadLine();
            Console.WriteLine("Koks jusu amzius?");
            var amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jūsų vardas {0},  o amžius {1}.", vardas, amzius);

        }
    }
}
