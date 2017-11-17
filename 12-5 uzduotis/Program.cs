using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1; 
            while (a % 9 != 0)
                            {
                Console.Write("Iveskite skaiciu");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Skaicius dalinas is 9");
        }
    }
}
