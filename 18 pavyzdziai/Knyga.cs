﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_pavyzdziai
{
    class Knyga
    {
        public int PuslapiuSkaicius;
        public string Autorius;
        public string Pavadinimas;
        public int Metai;

        public Knyga()
        {
            Console.WriteLine("Labas as esu konstruktoriuje");//konstruktorius
        }
        
        public Knyga(string pavadinimas, string autorius, int puslapiai, int metai)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            PuslapiuSkaicius = puslapiai;
            Metai = metai;
        }


        public void Isvedimas()
        {
            Console.WriteLine("Autorius {0} parase knyga {1}, kuria isleido {2} metas, jos puslapiu skaicius {3}.", Autorius, Pavadinimas, Metai, PuslapiuSkaicius);
            Console.WriteLine();

        }
    }
}
