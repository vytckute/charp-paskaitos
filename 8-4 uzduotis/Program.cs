using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            if (a > b || a == 0)
            {
                Console.WriteLine("ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0");
            }
             if (b > a || b == 5)
            {
                Console.WriteLine("ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5");
            }
             if (a > b && a == 20)
            {
                Console.WriteLine("ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20");
            }
             if (b > a && b < 100)
            {
                Console.WriteLine("ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100");
            }
      //      else { Console.WriteLine("Klaida"); }
        }
    }
}
