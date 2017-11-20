using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_3_uzduotis_kuro_sanaudos
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] kurossanaudos = { 3.5, 1.5, 1.6, 7, 3};
            double[] kilometrai = { 225.3, 300, 200, 300 };
            double min = 0;
            double max = 0;
            double sum = 0;
            double suma = 0;

            foreach (var km in kilometrai)
            {
                min = kilometrai.Min();
                max = kilometrai.Max();
                sum = kilometrai.Sum();
            }
            foreach (var ltr in kurossanaudos)
            {
                suma = kurossanaudos.Sum();
            }
            Console.WriteLine("Trumpiausia kelione" + min);
            Console.WriteLine("Ilgiausia kelione"+max);
            Console.WriteLine("Ilgiausia kelione" + max);
            Console.WriteLine(" vidutiniškai kuro sąnaudų sunaudojo automobilis" + (double)(suma / sum));
        }
    }
}
