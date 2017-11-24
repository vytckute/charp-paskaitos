using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_programa
{
    class Studentas
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public int Amzius { get; private set; }
        public string Grupe { get; private set; }
        public int Kursas { get; private set; }
        public List<int> Pazymiai { get; private set; }

        public Studentas(string vardas, string pavarde, int amzius, string grupe, int kursas, List<int> pazymiai)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Grupe = grupe;
            Kursas = kursas;
            Pazymiai = pazymiai;

        }
        public void Isvedimas()
        {
            Console.WriteLine("Studentas {0} {1} ({2}m.), grupe {3}, kursas {4}", Vardas, Pavarde, Amzius, Grupe, Kursas);
            Console.WriteLine("Pazymiai");
            foreach (var i in Pazymiai)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Studentas turi 10: " + KiekDesimtu(Pazymiai));
            Console.WriteLine();
            Console.WriteLine("Studentas turi 2: " + KiekDvejetu(Pazymiai));
            Console.WriteLine();
            Console.WriteLine("Vidurkis: " + Vidurkis(Pazymiai));

        }
        public int KiekDesimtu (List<int> pazymiai)
        {
            var suma = 0;
            foreach (var pazymys in Pazymiai)
            {
                if (pazymys==10)
                {
                    suma++;
                }
            }
            return suma;

        }
        public int KiekDvejetu(List<int> pazymiai)
        {
            var suma = 0;
            foreach (var pazymys in Pazymiai)
            {
                if (pazymys == 2)
                {
                    suma++;
                }
            }
            return suma;

        }

        public double Vidurkis(List<int> pazymiai)
        {
            return pazymiai.Average();
        }
    }
}
