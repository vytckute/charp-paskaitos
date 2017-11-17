using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //(Pažengusiems) Parašyti for ciklą, kuris leistų vartotojui pasirinkti kiek fibonačiaus skaičių išvesti į ekraną. Fibonačiaus sekoje kiekvienas skaičius yra 
            //lygus prieš jį ėjusių dviejų skaičių sumai: 1 1 2 3 5 8 11...
            Console.WriteLine("Iveskite fibonaciaus skaiciu");
            var n = Convert.ToInt32(Console.ReadLine());
            var a = 0;
            var b = 1;
            var c = 0;
       //     var sum = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
                       
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
           //     sum += c;

            }
            Console.WriteLine("------------------");


        }
    }
}
