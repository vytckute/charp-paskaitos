using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandymai
{
    class Program
    {
        static void Main(string[] args)
        { var sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum +=i;
               
            }
            Console.WriteLine(sum);
            Console.WriteLine("=====================");

            var max = 0;
            var max2 = 0;
            for (int i = 2; i <= 13195; i++)
            {
                if (13195 / i == 0)
                {  /*   { if (i > max2)
                               i = max2;
                               max2 = i; }*/
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(max2);
            }



        }
    }

