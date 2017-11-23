using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_parduotuve
{
    class Preke
    {
        public string Pavadinimas { get; private set; }
        public string Kodas { get; private set; }
        public double Kaina { get; private set; }
        public double SaviKaina { get; private set; }
        public int Kiekis { get; private set; }
    
     

public Preke(string pavadinimas, string kodas, double kaina, double savikaina, int kiekis)
{
    Pavadinimas = pavadinimas;
    Kodas = kodas; //konstruktorius
    Kaina = kaina;
    SaviKaina = savikaina;
    Kiekis = kiekis;
  
}

        public void Isvedimas() //isves viena preke
        {
            Console.WriteLine("Preke: {0}, {1}", Pavadinimas, Kodas);
            Console.WriteLine("Kaina {0}, savikaina {1}, kiekis {2}", Kaina, SaviKaina, Kiekis);
            Console.WriteLine();
        }
        public double PelnasIsPrekes()
        {
            return Kaina - SaviKaina;
        }
        public double PelnasPardavusVIsaKieki()
        {
            return Kiekis * PelnasIsPrekes();
        }

}
}
