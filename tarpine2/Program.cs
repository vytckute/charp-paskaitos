using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarpine2
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            var kvsuma = 0;
            for (int i = 1; i < 101; i++)
            {
                suma += i;
                kvsuma += (i*i);

            }
            Console.WriteLine(suma*suma-kvsuma);
        }
    }
}
