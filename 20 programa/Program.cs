using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            var universitetas= new Universitetas ("Ktu", "Kaunas", 25663 );
            universitetas.Isvedimas();
            Console.WriteLine();
            var darbuotojas = new Darbuotojas("Petras", "Petraitis", 20, 1500, 0.75);
            darbuotojas.Isvedimas();
            Console.WriteLine();
            var destytojas = new Destytojas("Jonas", "Jonaitis", 20, 1300, 1.0, "ekonominstu", 300);
            destytojas.Isvedimas();
            Console.WriteLine();
            var studentas = new Studentas("Vardas", "Pavarde", 21, "A5", 2, new List <int> { 2, 4, 10, 5, 6, 7, 8 });
            studentas.Isvedimas();
            Console.WriteLine();
            //Console.WriteLine("Studentas turi 10"+studentas.KiekDesimtu(List<int> pazymiai));
        }
    }
}
