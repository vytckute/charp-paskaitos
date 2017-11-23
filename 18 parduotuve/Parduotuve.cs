using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_parduotuve
{
    class Parduotuve
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Preke> Prekes { get; private set; } //ctor

        public Parduotuve(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas; //konstruktorius
            Adresas = adresas;
            Prekes = new List<Preke>(); //negauna prekiu todel sugeneruoja pats
                                        // SugeneruotiPrekes();

            Console.WriteLine("1. Generuoti prekes");
            Console.WriteLine("2. Suvesti prekes");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());
            switch (pasirinkimas)
            {
                case 1: SugeneruotiPrekes(); break;
                case 2: SuvestiPrekes(); break;
                default:
                    SugeneruotiPrekes(); //jei blogai suveda tegu generuoja
                    break;
            }

        }
        public Parduotuve(string pavadinimas, string adresas, List<Preke> prekes)
        {
            Pavadinimas = pavadinimas; //konstruktorius2
            Adresas = adresas;
            Prekes = prekes;

        }
        //sugeneruos automatiskai prekes
        public void SugeneruotiPrekes()
        {
            var rnd = new Random();
            var kiekPrekiu = rnd.Next(1, 20);
            string sakinys = "Lorem Ipsum Dolor Sit Amet Consectetur Adipiscing Elit Morbi Ultricies Urna Et Hendrerit Semper Libero Justo Iaculis Arcu Sed Laoreet";
            var zodziai = sakinys.Split(' ');

            for (int i = 0; i < kiekPrekiu; i++)
            {
                var pavadinimas = zodziai[rnd.Next(zodziai.Length)];
                var kodas = rnd.Next(10000, 100000).ToString();
                var kaina = rnd.Next(50, 100);
                var savikaina = rnd.Next(1, 50);
                var kiekis = rnd.Next(1, 100);
                var preke = new Preke(pavadinimas, kodas, kaina, savikaina, kiekis);
                Prekes.Add(preke);
            }
        }
        public void Isvedimas() //parduotuviu isvedimo metodas
        {
            Console.WriteLine("Pavadinimas " + Pavadinimas);
            Console.WriteLine("Adresas: " + Adresas);
            Console.WriteLine("Prekiu kiekis: " + Prekes.Count);
            Console.WriteLine();

            foreach (var preke in Prekes)
            {
                preke.Isvedimas(); //naudojamas metodas yra prekes klaseje
            }
            Console.WriteLine("Skaiciavimai: ");
            Console.WriteLine("Visu prekiu kainu suma "+KainuSuma());
            Console.WriteLine("Visu prekiu savikainu suma " + Savikainusuma());
            Console.WriteLine("Prekiu pajamos "+Prekiupajamos());
            Console.WriteLine("Bendras pelnas "+BendrasPelnas());
            Console.WriteLine();
            Console.WriteLine("Preke, kurios maziausias kiekis: ");
            MaziausiasKiekis().Isvedimas();
            Console.WriteLine("Preke, kurios didziausias kiekis: ");
            Didziausiaskiekis().Isvedimas();
            Console.WriteLine("Brangiausia preke: ");
            Brangiausia().Isvedimas();
            Console.WriteLine("Pigiausia preke: ");
            Pigiausia().Isvedimas();
        }
        public void SuvestiPrekes() //suves pats vartotojas
        {
            Console.WriteLine("Kiek prekiu suvesti?");
            var kiekSuvesti = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kiekSuvesti; i++)
            {
                Console.WriteLine("{0}-OJI PREKE", i + 1);
                Console.Write("Pavadinimas: ");
                var pavadinimas = Console.ReadLine();
                Console.Write("KOdas: ");
                var kodas = Console.ReadLine();
                Console.Write("Kaina: ");
                var kaina = Convert.ToDouble(Console.ReadLine());
                Console.Write("Savikaina: ");
                var savikaina = Convert.ToDouble(Console.ReadLine());
                Console.Write("Kiekis: ");
                var kiekis = Convert.ToInt32(Console.ReadLine());

                var preke = new Preke(pavadinimas, kodas, kaina, savikaina, kiekis);
                Prekes.Add(preke);
            }
        }
        public double KainuSuma()
        {
            var suma = 0.00;
            foreach (var preke in Prekes)
            {
                suma += preke.Kaina;
            }
            return suma;
        }
        public double Savikainusuma()
        {
            var suma = 0.00;
            foreach (var preke in Prekes)
            {
                suma += preke.SaviKaina;

            }
            return suma;
        }
        public double Prekiupajamos()
        {
            var prekiupajamos=0.00;
            foreach (var preke in Prekes)
            {
                prekiupajamos += preke.Kaina * preke.Kiekis;
            }
            return prekiupajamos;
        }
        public double BendrasPelnas()
        {
            var suma = 0.00;
            foreach (var preke in Prekes)
            {
                suma += preke.PelnasPardavusVIsaKieki();
            }
            return suma;
        }
        public Preke MaziausiasKiekis()
        {
            var maziausias = Prekes[0];
            foreach (var preke in Prekes)
             {if (preke.Kiekis < maziausias.Kiekis)
                {
                    maziausias = preke;
                }

            }
            return maziausias;
        }
        public Preke Didziausiaskiekis()
        {
            var didziausias = Prekes[0];
            foreach (var preke in Prekes)
            {
                if (preke.Kiekis > didziausias.Kiekis)
                {
                    didziausias = preke;
                }

            }
            return didziausias;
        }
        public Preke Pigiausia()
        {
            var pigiausia = Prekes[0];
            foreach (var preke in Prekes)
            {
                if (preke.Kaina < pigiausia.Kaina)
                {
                    pigiausia = preke;
                }

            }
            return pigiausia;
        }
        public Preke Brangiausia()
        {
            var brangiausia = Prekes[0];
            foreach (var preke in Prekes)
            {
                if (preke.Kaina > brangiausia.Kaina)
                {
                    brangiausia = preke;
                }

            }
            return brangiausia;
        }

    }
}
