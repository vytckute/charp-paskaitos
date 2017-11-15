using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite laipsnius");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kelvinu bus=" + (a + 273.16));
            Console.WriteLine("farengeitu bus=" + (a *9/5+32));
        }
    }
}
