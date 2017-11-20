using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = { 7, 8, 3, 4, 9, 10 };
            string[] markes = { "ford", "opel", "citroen" };
            char[] raides = { 't', 'p', 'k' };
            var naujas = new int[4];
            naujas[0] = 1;
            naujas[1] = 2;
            naujas[2] = 7;
            naujas[3] = 5;
            Console.WriteLine("Masyvų dydžiai");
            Console.WriteLine("pazymiai: " + pazymiai.Length);
            Console.WriteLine("raides: " + raides.Length);
            Console.WriteLine("markes: " + markes.Length);
            Console.WriteLine("paskutine pazymiu reiksme " + pazymiai.Last());
            Console.WriteLine("paskutine pazymiu reiksme " + pazymiai.First());


            var skaiciai = new int[5];
            Console.WriteLine("Iveskite 5 skaicius");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + ": ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
