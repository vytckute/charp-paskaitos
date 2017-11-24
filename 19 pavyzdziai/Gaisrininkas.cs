using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_pavyzdziai
{
    class Gaisrininkas:Darbuotojas
    {
        public string Postas { get; private set; }

        public Gaisrininkas(string vardas, string pavarde, int amzius, double alga, double etatas, string postas)
            : base(vardas, pavarde, amzius, alga, etatas)
        {
            Postas = postas;

        }

        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Gaisrininkas dirba poste "+ Postas);
        }
    }
}
