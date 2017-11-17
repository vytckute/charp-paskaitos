using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pradzios rezi");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pabaigos rezi");
            var b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                for ( int i=a; i < b; i++)
                {
                    Console.WriteLine(i + " " + (i * i));
                }
            }

        }
    }
}
