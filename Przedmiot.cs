using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPlecakowy
{
    internal class Przedmiot
    {
        public int Waga { get; set; }
        public int Wartosc { get; set; }
        public int Indeks { get; set;}
        public Przedmiot(int waga, int wartosc, int indeks)
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
