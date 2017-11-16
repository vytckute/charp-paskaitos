using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2__uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite rezultata");
            var rez = Convert.ToInt32(Console.ReadLine());
            if (rez == 100)
            { Console.WriteLine("rezultatas yra lygus 100"); }
            else if (rez >= 80)
            { Console.WriteLine(" yra lygus arba didesnis nei 80"); }
            else if (rez >= 50)
            { Console.WriteLine(" yra lygus arba didesnis nei 50"); }
            else if (rez >= 20)
            { Console.WriteLine(" yra lygus arba didesnis nei 20"); }
        }
    }
}
