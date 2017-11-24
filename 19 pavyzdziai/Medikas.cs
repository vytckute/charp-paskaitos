using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_pavyzdziai
{
        class Medikas :Darbuotojas
    {
        public int PalatuSkaicius { get; private set; }
        public string Skyrius { get; private set; }

        public Medikas(string vardas, string pavarde, int amzius, double alga, double etatas, int palatuskaicius, string skyrius)
             : base(vardas, pavarde, amzius, alga, etatas)
        {
            palatuskaicius = PalatuSkaicius;
            skyrius = Skyrius;
        }

        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Medikas turi palatu {0} ir dirba skyriuje {1}",PalatuSkaicius, Skyrius);
        }
    }
}
