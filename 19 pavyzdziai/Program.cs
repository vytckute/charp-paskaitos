using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var darbuotojas = new Darbuotojas("Vaida", "Leskauskaite", 20, 500, 1); //objekto kurimas
            darbuotojas.Isvedimas();
            Console.WriteLine();
            var policininkas = new Policininkas("Petras", "Policininkas", 30, 600, 1, 100, 20); //objekto kurimas
            policininkas.Isvedimas();
            Console.WriteLine();
            var medikas = new Medikas("Jonas", "Jonaitis", 30, 2500,0.5,30, "Nantalogijos");
            medikas.Isvedimas();
            Console.WriteLine();
            var gaisrininkas = new Gaisrininkas("Petras", "Petraitis", 35, 1500, 0.75, "Kauno");
            gaisrininkas.Isvedimas();
            Console.WriteLine();
        }
    }
}
