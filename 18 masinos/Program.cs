using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_masinos
{
    class Program
    {
        static void Main(string[] args)
        {
            var automobilis = new Automobilis("Audi", "A4", 2017, 2.2, 150, 3);
            automobilis.Isvedimas();
            var automobiliai = new List<Automobilis>
            {
                new Automobilis ("Opel", "Vectra", 2015,1.6,152,1500),
                new Automobilis ("Ford", "focus", 2010, 1.5, 188, 20000),
                new Automobilis ("Citroen", "C5", 2006, 3.0, 210, 1562),
                new Automobilis ("Citroen", "saxo", 2010, 1.7, 125, 1580)
                            };
            var programa = new Program();
            programa.Isvedimas(automobiliai);
            var naujausias = programa.NaujasAuto(automobiliai);
            Console.WriteLine("Naujausias auto:");
            naujausias.Isvedimas();
            var seniausias = programa.SenasAuto(automobiliai);
            Console.WriteLine("Seniausias auto:");
            seniausias.Isvedimas();
            var MaxGalia = programa.DideliaGalia(automobiliai);
            Console.WriteLine("Didziausios galios automobilis:");
            MaxGalia.Isvedimas();
            var MinKm = programa.MaziausiaRida(automobiliai);
            Console.WriteLine("Maziausiai nuvaziaves:");
            MinKm.Isvedimas();
        }
        public void Isvedimas(List<Automobilis> automobiliai)
        {
            foreach (var auto in automobiliai)
            {
                auto.Isvedimas();

            }
        }
        public Automobilis NaujasAuto(List<Automobilis> automobilai)
        {
            var laikinas = automobilai.First();
            foreach (var auto in automobilai)
            {
                if (auto.Metai>laikinas.Metai)
                {
                    laikinas = auto;
                  
                }
            }
            return laikinas;
        }
        public Automobilis SenasAuto(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();
            foreach (var auto in automobiliai)
            {
                if (auto.Metai<laikinas.Metai)
                {
                    laikinas = auto;
                }

            }
            return laikinas;
        }

        public Automobilis DideliaGalia(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();
            foreach (var auto in automobiliai)
            {
                if (auto.Galia > laikinas.Galia)
                {
                    laikinas = auto;
                }

            }
            return laikinas;
        }

        public Automobilis MaziausiaRida(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();
            foreach (var auto in automobiliai)
            {
                if (auto.Rida < laikinas.Rida)
                { laikinas = auto;
                }

            }
            return laikinas;
        }
    }
}
