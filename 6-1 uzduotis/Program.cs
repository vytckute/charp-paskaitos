using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 3 skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            if (a > b) { Console.WriteLine("ar pirmas skaičius didesnis už antrą"); }
            else if (b>c) { Console.WriteLine("ar antras skaičius didesnis už trečią;"); }
            else if (a>c) { Console.WriteLine("ar trečias skaičius skaičius didesnis už pirmą;"); }
            else if (a==b && b==c && a==c) { Console.WriteLine("ar skaičiai lygūs;"); }
        }
    }
}
