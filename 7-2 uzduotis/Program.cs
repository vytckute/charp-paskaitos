using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            { Console.WriteLine("SKaicius {0} neigiamas",a); }
            else if (a > 0)
            { Console.WriteLine("SKaicius {0} teigiamas",a); }
            else
            { Console.WriteLine("SKaicius =0"); }
        }
    }
}
