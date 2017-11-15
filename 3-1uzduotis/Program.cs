using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 10;
            Console.WriteLine(a+b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);

            var suma = a + b;
            var skirtumas = a - b;
            var sandauga = a * b;
            var dalmuo = a / b;
            Console.WriteLine("{0}+{1}={2}", a, b, suma);
            Console.WriteLine("{0}-{1}={2}", a, b, skirtumas);
            Console.WriteLine("{0}*{1}={2}", a, b, sandauga);
            Console.WriteLine("{0}/{1}={2}", a, b, dalmuo);

        }
    }
}
