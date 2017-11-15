using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite simboli");
            var simb = Console.ReadLine();
            Console.WriteLine("{0}{0}{0}", simb);
            Console.WriteLine("{0}{0}{0}", simb);
            Console.WriteLine("{0}{0}{0}", simb);
        }
    }
}
