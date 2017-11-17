using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int pasi;
            do
            {
                Console.WriteLine("1 - šuo, 2 - katė, 3 - žiurkėnas");
                pasi = Convert.ToInt32(Console.ReadLine());
                if (pasi < 1 || pasi > 3)
                { Console.WriteLine("Tokios varianto nera"); }

            } while (pasi < 1 || pasi > 3);
            Console.WriteLine("pasirinkimas:" + pasi);
        }
    }
}
