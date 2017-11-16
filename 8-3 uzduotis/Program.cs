using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris pazymius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (Double)(a + b + c) / 3;
            if (vidurkis >= 8 && vidurkis <= 10)
            { Console.WriteLine("gautas vidurkis yra [8-10]" + vidurkis); }
            else if (vidurkis >= 5 && vidurkis <8)
            { Console.WriteLine("gautas vidurkis yra[5 - 8);" + vidurkis); }
            else if (vidurkis < 5)
            { Console.WriteLine("gautas vidurkis yra < 5" + vidurkis); }
            else { Console.WriteLine("Nepatenka i rezius"); }
        }
    }
}
