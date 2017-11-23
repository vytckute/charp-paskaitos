using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_studentas
{
    class Program
    {
        static void Main(string[] args)
        {
            var Studentas = new Studentas("Haris", "Poteris", "Ryzas", 20, 
                new List<int>
                {
                    7,8,9,6,3
                }
                , new List<int>
                {
                  4,7,5,8,9,10
                }
                 ,new List<int>
                {
                  10,10,9,2
                }                    
                       );
            Studentas.Isvedimas();
        }
    }
}
