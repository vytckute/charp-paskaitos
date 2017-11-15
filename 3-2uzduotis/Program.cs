using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var kvadratas = a * a;
            var kubas = a * a * a;
            Console.WriteLine("Skaičius {0} kvadratas yra {1} kūbas yra {2}", a, kvadratas, kubas);
            Console.WriteLine(Math.Pow(a, 3));
       
        }
    }
}
