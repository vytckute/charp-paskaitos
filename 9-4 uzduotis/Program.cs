using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - stacionarus kompiuteris");
            Console.WriteLine("2 - nešiojamas kompiuteris");
            Console.WriteLine("3 - planšetė");
            Console.WriteLine("Pasirinkite vieną, įvedant skaičių");
            var a = Convert.ToInt32(Console.ReadLine());
            switch (a)
                {
                case 1:
                    Console.WriteLine("stacionariu kompiuteriu galite naudotis namie");
                    break;
                case 2:
                    Console.WriteLine("nešiojamuoju kompiuteriu galite naudotis visur");
                    break;
                case 3:
                    Console.WriteLine("plansete galite naudotis visur");
                    break;
                default:
                    Console.WriteLine("Tokio varianto nera");
                    break;
            }
        }
    }
}
