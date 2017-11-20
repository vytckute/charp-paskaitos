using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<string> zodziai = new List<string> { "namas", "abu", "svajonese", "keliones"};
           var max = zodziai[0];
            var min = zodziai[0];
            foreach (var zodis in zodziai)
            {
                
                if (zodis.Length>max.Length)
                {
                    max = zodis;
                }
              
                if ((zodis.Length) <min.Length)
                {
                    min= zodis;
                }
            }
            Console.WriteLine("Ilgiausias zodis: "+max +" Raidziu kiekis: "+max.Length);
            Console.WriteLine("Trumpiausias zodis: "+min + " Raidziu kiekis: "+min.Length);
        }
    }
}
