using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite vartotojo atlyginimus");
            List<double> atlyginimai = new List<double>();
            var programa = new Program();
            programa.Ivedimas(atlyginimai);
            programa.Isvedimas(atlyginimai);
            programa.Vidurkis(atlyginimai);
            programa.MaziausiaAlga(atlyginimai);
            programa.DidziausiaAlga(atlyginimai);
            Console.WriteLine("Daugiau uz vidurki atlyginimu: " + programa.daugiauuzvidurki(atlyginimai));
            Console.WriteLine("Daugiau uz 1500 atlyginimu: " + programa.daugiau1500(atlyginimai));
                programa.max3reiksmes(atlyginimai);
            Console.WriteLine("Penktas didziausias"+programa.penktasmax(atlyginimai));
        }
        public void Ivedimas(List<double> atlyginimai)
        {
            Console.WriteLine("Kiek atlyginimu norite suvesti:");
            var kiekis = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kiekis; i++)
            {
                Console.WriteLine("Iveskite atlyginima {0}", i + 1);
                atlyginimai.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }

        public void Isvedimas(List<double> atlyg)
        { foreach (var atl in atlyg)
            { Console.Write("[{0}] ", atl);
            }
        }



        public double Vidurkis(List<double> atlyginimai)
        {
            var vidurkis = atlyginimai.Average();

            Console.WriteLine("Vidutinis atlyginimas " + vidurkis);
            return vidurkis;
        }
        public double MaziausiaAlga(List<double> atlyginimai)
        {
            var min = atlyginimai.Min();

            Console.WriteLine("Maziausias atlyginimas " + min);
            return min;
        }
        public double DidziausiaAlga(List<double> atlyginimai)
        {
            var max = atlyginimai.Max();

            Console.WriteLine("Didziausias atlyginimas " + max);
            return max;
        }
        public int daugiauuzvidurki(List<double> atlyginimai)
        {
            var kiekis = 0;
            var vidurkis = Vidurkis(atlyginimai);
            foreach (var atl in atlyginimai)
            {
                if (atl > vidurkis)
                { kiekis++; }

            }
            return kiekis;
        }

        public int daugiau1500(List<double> atlyginimai)
        {
            var kiekis = 0;
            foreach (var atl in atlyginimai)
            {
                if (atl > 1500)
                { kiekis++; }

            }
            return kiekis;
        }

        public void max3reiksmes(List<double> atlyginimai)
        {
            double max1 = atlyginimai.Max();
            double max2 = 0; double max3 = 0;
         
              foreach (var atlyg in atlyginimai)
               {    
                   if (atlyg < max1 && atlyg > max2 )
                   {
                       max2 = atlyg;


                   }
                   if (atlyg < max1 && atlyg < max2 && atlyg > max3)
                   {
                       max3 = atlyg;


                   }
               }
               Console.WriteLine("Pirmas didŽiausias:" + max1);
               Console.WriteLine("Antras didŽiausias:" + max2);
               Console.WriteLine("Treacias didŽiausias:" + max3);
           }

        public double penktasmax(List<double> atlyginimai)
        {
            atlyginimai.Sort();
            atlyginimai.Reverse();
                     return atlyginimai[4];
        }
        }
    }
    

