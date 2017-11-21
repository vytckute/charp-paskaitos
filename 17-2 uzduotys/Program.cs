using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_2_uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double>primilziai=new List<double>();
            var programa = new Program();
            programa.Ivedimas(primilziai);
            programa.Isvedimas(primilziai);
            Console.WriteLine("Minimali reiksme "+programa.minimalireiksme(primilziai));
            Console.WriteLine("Maximali reiksme " + programa.maximalireiksme(primilziai));
            Console.WriteLine("VIdurkis reiksme " + programa.vidurkis(primilziai));
            programa.dumax(primilziai);
        }

        public void Ivedimas(List<double> primilziai)
        {
            Console.WriteLine("Kiek ivesti:");
            var kiekis = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kiekis; i++)
            {
                Console.WriteLine("iveskite:");
                primilziai.Add(Convert.ToDouble(Console.ReadLine()));
            }
           
        }
        public void Isvedimas(List<double> primilziai)
        {
            foreach (var prim in primilziai)
            {
                Console.Write("[{0}]", prim);
            }
        }
        public double minimalireiksme(List<double> primilziai)
        {
           return primilziai.Min();
                     }
        public double maximalireiksme(List<double> primilziai)
        {
            return primilziai.Max();
        }

        public double vidurkis(List<double> primilziai)
        {
            return primilziai.Average();
        }

        public void dumax(List<double> primilziai)
        {
            var max1 = primilziai.Max();
          
            double max2 = 0;
            foreach (var pri in primilziai)
            {
                if (pri<max1 && pri>max2)
                {
                    max2 = pri;
                }

            }
            Console.WriteLine("Max1= "+max1);
            Console.WriteLine("Max2= "+max2);
        }

    }
}
