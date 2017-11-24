using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_programa
{
    class Universitetas
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public int Kodas { get; private set; }

        public Universitetas (string pavadinimas, string adresas, int kodas)
            {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Kodas = kodas;
            }
        public void Isvedimas()
        {
            Console.WriteLine("Universitetas {0} yra adresu {1}, kodas {2}", Pavadinimas, Adresas, Kodas);
        }
    }
}
