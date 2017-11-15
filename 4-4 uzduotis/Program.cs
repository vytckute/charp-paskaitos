using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu a");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu b");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu c");
            var c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a+b+c=" + (a + b + c));
            Console.WriteLine("a-b-c=" + (a - b - c));
            Console.WriteLine("a*b*c=" + (a * b * c));
            Console.WriteLine("a/b/c=" + (a / b / c));
        }
    }
}
