using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_medis
{
    class Program
    {
        static void Main(string[] args)
        {
            var medis = new Medis("Klevas", 20, 2.36);
            medis.Isvedimas();
            var programa = new Program();
            Console.WriteLine("Aukstis "+medis.centimetrai());
            Console.WriteLine("Aukstis " + medis.kadapasodinta());
        }
     

        
    }
}
