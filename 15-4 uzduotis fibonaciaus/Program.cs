using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_4_uzduotis_fibonaciaus
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var masyvas = new int[10];
            masyvas[0] = 0;
            masyvas[1] = 1;
            //Console.WriteLine(masyvas[0]);
            //////Console.WriteLine(masyvas[1]);
            for (int i = 2; i < 10; i++)
            {
                masyvas[i] = masyvas[i - 1] + masyvas[i - 2];           

                //Console.WriteLine(masyvas[i]);
            }

            foreach (var skaicius in masyvas)
            {
                Console.WriteLine (skaicius);
            }
        }
    } }

