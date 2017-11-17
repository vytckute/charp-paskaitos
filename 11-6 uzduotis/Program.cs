using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_6_uzduotis
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
                for (int i = a; i < b; i++)
                {
                    if (i%2!=0 || i%8==0)
                    Console.WriteLine(i);
                }
            }
        }
    }
}
