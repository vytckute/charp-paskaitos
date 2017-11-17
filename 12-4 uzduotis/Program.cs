using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "";
            var tekstas = "";
            while (a != "exit")
            {    Console.WriteLine("Iveskite zodi arba exit");
                a = Console.ReadLine();
                 
                if ( a!="exit")
                {
             tekstas += a + " ";
                }


            }
            Console.WriteLine(tekstas);
        }
    }
}
