using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPlecakowy
{
    internal class Problem
    {
       public int LiczbaN { get; set; }
        public List<Przedmiot> Przedmioty { get; set; }

        public Problem(int n, int seed)
        {
            LiczbaN = n;
            Przedmioty = new List<Przedmiot>();
            Random random = new Random(seed);
            for (int i = 0; i < n; i++)
            {
                int waga = random.Next(1, 11);
                int wartosc = random.Next(1, 11);
                Przedmioty.Add(new Przedmiot(waga, wartosc));
            }
        }
        public Result Solve(int capacity)
        {
            var sortedItems = Przedmioty.OrderByDescending(p=>(double)p.Wartosc/p.Waga).ToList();
            List<int> selectedItems = new List<int>();
            int totalWeight = 0, totalValue = 0;
            for(int i=0;i<sortedItems.Count;i++)
            {
                if (totalWeight + sortedItems[i].Waga<=capacity)
                {
                    selectedItems.Add(i);
                    totalWeight += sortedItems[i].Waga;
                    totalValue += sortedItems[i].Wartosc;
                }
            }
            return new Result(selectedItems, totalValue, totalWeight);
        }
        public override string ToString()
        {
            string result = "Lista przedmiotow:\n";
            for(int i=0; i<Przedmioty.Count;i++)
            {
                result += $"Przedmiot{i+1}: Waga= {Przedmioty[i].Waga}, Wartosc={Przedmioty[i].Wartosc}\n"; 
            }
            return result;
        }

    }
}
