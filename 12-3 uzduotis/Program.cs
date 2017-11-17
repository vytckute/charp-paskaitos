using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var veiksmas = "t";
            while (veiksmas == "t")
            {
                Console.WriteLine("Iveskite du skaicius");
                var a = Convert.ToInt32(Console.ReadLine());
                var b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}+{1}={2}", a, b, (a + b));
                Console.WriteLine("{0}-{1}={2}", a, b,  (a - b));
                Console.WriteLine("{0}*{1}={2}", a, b, (a * b));
                Console.WriteLine("{0}/{1}={2}", a, b, (double)(a / b));
                Console.WriteLine("Ar norite testi (t/n)");
                veiksmas = Console.ReadLine();
            }
        }
    }
}