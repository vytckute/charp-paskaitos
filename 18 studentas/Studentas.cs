using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_studentas
{
    class Studentas
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public string Pravarde { get; private set; }
        public int Amzius { get; private set; }
        public List<int> MatematikosPazymiai { get; private set; }
        public List<int> InformatikosPazymiai { get; private set; }
        public List<int> BiolagijosPazymiai { get; private set; }

        public Studentas(string vardas, string pavarde, string pravarde, int amzius, List<int> matematikospazymiai, List<int> informatikospazymiai, List<int> biologijospazymiai)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Pravarde = pravarde;
            Amzius = amzius;
            MatematikosPazymiai = matematikospazymiai;
            InformatikosPazymiai = informatikospazymiai;
            BiolagijosPazymiai = biologijospazymiai;
        }
        public void Isvedimas()
        {
            Console.WriteLine("Studentas: {0} {1} ({2}m.)", Vardas, Pavarde,Amzius);
            Console.WriteLine("Turi {0} pravarde", Pravarde);
            Console.WriteLine("Matematikos pazymiai: ");
            foreach (var i in MatematikosPazymiai)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Informatikos pazymiai: ");
            foreach (var i in InformatikosPazymiai)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Biologijos pazymiai: ");
            foreach (var i in BiolagijosPazymiai)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Visu pazymiu vidurkis: "+ Math.Round(Vidurkis(),2)); //apvalina 2sk po kablelio
            Console.WriteLine("Didziausias pazymys: "+Didziausias());
        }
        public double Vidurkis()
        {
            return (MatematikosPazymiai.Average() + InformatikosPazymiai.Average() + BiolagijosPazymiai.Average()) / 3;
        }

        public int Didziausias()
        {
           var pirmas= BiolagijosPazymiai.Max();
           var antras= MatematikosPazymiai.Max();
          var trecias=  InformatikosPazymiai.Max();
           
            if (pirmas >antras &&pirmas>trecias)
            {

                return pirmas;
            }
          else  if (antras > pirmas && antras>trecias)
            {

                return antras;
            }
            else if (trecias > pirmas && trecias > antras)
            {

                return trecias;
                      }
            return pirmas;//skaiciai lygus, grazina bet kuri


        }
    }
}
