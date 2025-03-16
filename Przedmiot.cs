using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace ProjektPlecakowy
{
    internal class Przedmiot
    {
        public int Indeks { get; set;}
        public int Waga { get; set; }
        public int Wartosc { get; set; }
        public Przedmiot(int indeks, int waga, int wartosc)
        {
            Waga = waga;
            Wartosc = wartosc;
            Indeks = indeks;
            
        }
        public override string ToString()
    {
        return $"[#{Indeks}] Waga: {Waga}, Wartość: {Wartosc}";
    }
    }

    
}
