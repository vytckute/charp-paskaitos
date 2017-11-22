using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_masinos
{
    class Automobilis
    {
        public String  Marke { get; private set; } //propg greitai imeta, Property get
        public String Modelis { get; private set; }
        public int Metai { get; private set; } 
        public double Darbinisturis { get; private set; } 
        public int Galia { get; private set; } //kw
        public int Rida { get; private set; }

        public Automobilis(string marke, string modelis, int metai, double darbinisTuris, int galia, int rida) //konstruktorius su parametrais
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            Darbinisturis = darbinisTuris;
            Galia = galia;
            Rida = rida;
        }
        public void Isvedimas()
        {
            Console.WriteLine("Automobilis, kurio marke {0} modelis {1}, darbinis turis {2}, galia {3}, rida {4}, metai {5}.", Marke, Modelis, Darbinisturis, Galia, Rida, Metai);
            Console.WriteLine();
        }

    }
}
