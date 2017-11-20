using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_temperaturu_masivas
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturos = { 14.5, 18.5, 20.4, -30 };

            var zemiausia = temperaturos[0];
            foreach (var temperatura in temperaturos)
            {
                if (temperatura<zemiausia)
                {
                    zemiausia =temperatura;
                }
            }
            Console.WriteLine(zemiausia);

            var auskciausia = temperaturos[0];
            foreach (var temperatura in temperaturos)
            {
                if (temperatura > auskciausia)
                {
                    auskciausia = temperatura;
                }
            }
            Console.WriteLine(auskciausia);

            double suma = 0;
            foreach (var temperatura in temperaturos)
            { suma += temperatura;
            }
            var vidurkis = (double)suma / temperaturos.Length;
            Console.WriteLine("vidurkis" + vidurkis);

            var kiekis = 0;
            var kiekis2 = 0;
            foreach (var temperatura in temperaturos)
            {
                if (temperatura <vidurkis)
                {
                    kiekis ++;

                }

                if (temperatura > vidurkis)
                {
                    kiekis2++;

                }
            }
            Console.WriteLine("Kiekis mazesniu uz vidurkis "+kiekis);
            Console.WriteLine("Kiekis didesniu uz vidurkis " + kiekis2);
        }

    }
}
