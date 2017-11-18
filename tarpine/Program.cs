using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarpine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; ; i++)
            {
                var suma = 0;
                for (int j = 1; j < 21; j++)
                {
                    if (i % j == 0)
                    {
                        suma++;

                    }
                }


                if (suma == 20)
                {
                    Console.WriteLine("Skacius dalinantis is visu skaiciu nuo 1 iki 20="+i); //randa tik ilgai reikia laukti 
                    break;
                }
            }
        }
    }
}
            
        
     
        
