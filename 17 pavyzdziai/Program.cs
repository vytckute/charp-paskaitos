using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Pasisveikinti();
            programa.Pasisveikinti("Ieva");
            programa.Pasisveikinti("Ieva", "Jaksaityte");
            programa.Atsisveikinti("Vita");
            programa.Atsisveikinti("Vita", "Luk");
            Math.Sin(4.5);
            StatinisMEtodas();
           var sumosats= programa.Suma(4, 5);
            Console.WriteLine(sumosats);

            Console.WriteLine(programa.Suma(7,5));
            Console.WriteLine(programa.Skirtumas(10,5));
            Console.WriteLine(programa.Daugyba(15,2));
            Console.WriteLine(programa.Dalmuo(25,6));

            Console.WriteLine("Iveskite du skaicius:");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(programa.Suma(pirmas, antras));
            Console.WriteLine(programa.Skirtumas(pirmas, antras));
            Console.WriteLine(programa.Daugyba(pirmas, antras));
            Console.WriteLine(programa.Dalmuo(pirmas, antras));
            var suma = programa.Suma(pirmas, antras);
            var skirtumas = programa.Skirtumas(pirmas, antras);
            var daugyba = programa.Daugyba(pirmas, antras);
            var dalmuo = programa.Dalmuo(pirmas, antras);
            
            Console.WriteLine("{0}+{1}={2}", pirmas, antras, suma);
            Console.WriteLine("{0}-{1}={2}", pirmas, antras, skirtumas);
            Console.WriteLine("{0}*{1}={2}", pirmas, antras, daugyba);
            Console.WriteLine("{0}/{1}={2}", pirmas, antras, dalmuo);

            Console.WriteLine("Iveskite staciakampio krastines: ");
            var ilgis = Convert.ToDouble(Console.ReadLine());
            var plotis = Convert.ToDouble(Console.ReadLine());
            var perimetras = programa.perimetras(ilgis, plotis);
            Console.WriteLine("Staciakampio perimatras kurio krastines {0} ir {1} yra {2}", ilgis, plotis, perimetras);
            var plotas = programa.plotas(ilgis, plotis);
            Console.WriteLine("Staciakampio plotas kurio krastines {0} ir {1} yra {2}", ilgis, plotis, plotas);
            Console.WriteLine("Iveskite trikampio pagrinda ir aukstine:");
            var a = Convert.ToDouble(Console.ReadLine());
            var h = Convert.ToDouble(Console.ReadLine());
            var trplotas = programa.trikampioplotas(a, h);
            Console.WriteLine("S=1/2*{0}*{1}={2}",a,h,trplotas);


            /*pasiekiamumas tipas pavadinimai (parametrai)*/
        }
        public void Pasisveikinti()
        {
            var skaicius = 5;
            Console.WriteLine("Labas");
        }

        public void Pasisveikinti(string vardas)
        {
            var skaicius = 5;
            Console.WriteLine("Labas" + vardas); }

        public void Pasisveikinti(string vardas, string pavarde)
        { Console.WriteLine("Labas, "+vardas+" "+pavarde); }

        public void Atsisveikinti(string vardas)
        { Console.WriteLine("Ate, "+vardas); }

        public void Atsisveikinti(string vardas, string pavarde)
        { Console.WriteLine("Ate, "+vardas+" "+pavarde); }

        public static void StatinisMEtodas()
        {
            Console.WriteLine("Statinis metodas");
        }
        public int Suma(int a, int b)
        {
            return a + b;
        }
        public int Skirtumas(int a, int b)
        { return a - b; }

        public int Daugyba(int a, int b)
        { return a * b; }

        public double Dalmuo(int a, int b)
        { return (double) a / b; }

        public double perimetras(double ilgis, double plotis)
        {
            return (ilgis + plotis) * 2;
        }

        public double plotas(double ilgis, double plotis)
        {
            return ilgis * plotis;
        }

        public double trikampioplotas(double a, double h)
        {
            return 0.5 * a * h;
        }
    }
}
