using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            //   var slap = 3;
            var random = new Random();
            int slap = random.Next(1, 11);

            var slapObj = new Random();

            if (a >= 1 && a <= 10)
            {
                while (a != slap)
                {
                    Console.WriteLine("Bandykite atspeti skaiciu slapta nuo 1 iki 10");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a > slap)
                    {
                        Console.WriteLine("Skaicius mazesnis");
                    }
                    else { Console.WriteLine("Skaicius didesnis"); }

                }
                Console.WriteLine("Atspejote");
            }
            else { Console.WriteLine("Skaicius nera nuo 1 iki 10"); }

        }
    }
}
