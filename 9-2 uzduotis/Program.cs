using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite gyvuna");
            var gyvunas = Console.ReadLine();
            switch (gyvunas)
                {
                case ("suo"):
                    Console.WriteLine(" įvestas gyvūnas yra šuo");
                    break;
                case ("kate"):
                    Console.WriteLine(" įvestas gyvūnas yra kate");
                    break;
                case ("ziurkenas"):
                    Console.WriteLine(" įvestas gyvūnas yra ziurkenas");
                    break;
                case ("triusis"):
                    Console.WriteLine(" įvestas gyvūnas yra trusis");
                    break;
                case ("papuga"):
                    Console.WriteLine(" įvestas gyvūnas yra papuga");
                    break;

            }
        }
    }
}
