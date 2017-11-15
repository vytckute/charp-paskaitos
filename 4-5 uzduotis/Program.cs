using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sveika skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}*1="+(a*1),a);
            Console.WriteLine("{0}*2=" + (a * 2), a);
            Console.WriteLine("{0}*3=" + (a * 3), a);
            Console.WriteLine("{0}*4=" + (a * 4), a);
            Console.WriteLine("{0}*5=" + (a * 5), a);
            
        }
    }
}
