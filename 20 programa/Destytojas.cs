using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_programa
{
    class Destytojas:Darbuotojas
    {
        public string Srautas { get; private set; }
        public int StudentuSemestre { get; private set; }

        public Destytojas (string vardas, string pavarde, int amzius, double alga, double etatas, string srautas, int studentusemestre)
            :base (vardas, pavarde, amzius, alga, etatas)
            {
            Srautas = srautas;
            StudentuSemestre = studentusemestre;
            }

        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Turi srauta {0} ir studentu semestre {1}", Srautas, StudentuSemestre);
            Console.WriteLine();
        }

    }
}
