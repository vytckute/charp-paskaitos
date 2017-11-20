using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kiek pazymiu norite ivesti");
            var kiekis = Convert.ToInt32(Console.ReadLine());
            List<int> pazymiai = new List<int>();
            var atsitiktinis = new Random();

            for (int i = 0; i < kiekis; i++)
            {
                Console.Write("Iveskite pazymi:" + (i + 1) + " ");
                pazymiai.Add(Convert.ToInt32(Console.ReadLine()));

            }
            Console.WriteLine("Didžiausias pažymys: " + pazymiai.Max());
            Console.WriteLine("Maziausias pažymys: " + pazymiai.Min());
            Console.WriteLine("Vidurkis: " + pazymiai.Average());

            Console.WriteLine("Atsitiktinis " + pazymiai[atsitiktinis.Next(pazymiai.Count)]);
              

        }
    }
}
