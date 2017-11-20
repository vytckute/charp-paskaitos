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
        {/* var sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum +=i;
               
            }
            Console.WriteLine(sum);
            Console.WriteLine("====================="); */
           // 600851475143
            var sum = 0;
            var max = 0;
            for (var i = 2; i < 6008514751; i++)
            {
                sum = 0;
                if (6008514751 % i==0)
                {
                    
                    for (int j = 1; j < i+1; j++)
                    {
                        if (i % j == 0)
                        { sum++; }
                    }
                       
                         if (sum == 2)
                        {
                        
                            max = i;
                           
                        }
                      //  Console.WriteLine(max);
                    }
                
            }
                  Console.WriteLine(max);      

                    }
                }
            }

        
            
        
            
        
       

