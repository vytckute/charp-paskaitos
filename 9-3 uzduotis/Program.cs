using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - vanduo");
            Console.WriteLine("2 - kava");
            Console.WriteLine("3 - arbata");
            Console.WriteLine("4 - saldainiai");
            Console.WriteLine("Pasirinkite vieną, įvedant skaičių");
            var a = Convert.ToInt32(Console.ReadLine());
            switch (a) {
                case 1:
                    Console.WriteLine("Pasirikimas vanduo");
                    break;
                case 2:
                    Console.WriteLine("Pasirikimas kava");
                    break;
                case 3:
                    Console.WriteLine("Pasirikimas arbata");
                    break;
                case 4:
                    Console.WriteLine("Pasirikimas saldainiai");
                    break;
                default:
                    Console.WriteLine("Tokio varianto nera");
                    break;
            }       
        }
    }
}
