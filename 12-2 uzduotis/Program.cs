using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite neigiama skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                while (a < 0)
                {
                    Console.WriteLine(a);
                    a++;

                }
            }
            else { Console.WriteLine("Skaicius teigiamas"); }
        }
    }
}
