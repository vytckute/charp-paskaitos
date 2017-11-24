using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_pavyzdziai
{
    class Policininkas:Darbuotojas
    {
        public double Kysis { get; private set; }
        public int KieksuemeNusikalteliu { get; private set; }

        public Policininkas (string vardas, string pavarde, int amzius, double alga, double etatas, double kysis, int kieksuemenusikalteliu)
            :base(vardas, pavarde,amzius, alga, etatas)
{            Kysis=kysis;
            KieksuemeNusikalteliu = kieksuemenusikalteliu;

            }
        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Gauna kysio: "+Kysis);
            Console.WriteLine("Sugavo nusikalteliu: "+KieksuemeNusikalteliu);
            Console.WriteLine();
        }

    }
}
