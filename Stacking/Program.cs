using System;
using System.Collections.Generic;

namespace Stacking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stacking Cups
            int size;
            int amount = int.Parse(Console.ReadLine());
            SortedDictionary<int, string> cups = new SortedDictionary<int, string>();
            for (int i = 0; i < amount; i++)
            {
                string[] cup = Console.ReadLine().Split(" ");
                var isNumeric = double.TryParse(cup[0], out double n);
                if (isNumeric)
                {
                    size = int.Parse(cup[0]) / 2;
                    cups.Add(size, cup[1]);
                }
                else
                {
                    size = int.Parse(cup[1]);
                    cups.Add(size, cup[0]);
                }
                
            }
            foreach (var cup in cups)
            {
                Console.WriteLine(cup.Value);
            }
        }
    }
}
