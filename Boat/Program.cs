using System;
using System.Collections.Generic;

namespace Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boat parts
            int[] values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            HashSet<string> partName = new HashSet<string>();
            string part;
            int days = 0;
            for (int i = 0; i < values[1]; i++)
            {
                part = Console.ReadLine();
                partName.Add(part);
                if (partName.Count == values[0])
                {
                    days = i + 1;
                    break;
                }
            }
            if (days == 0)
            {
                Console.WriteLine("paradox avoided");
            }
            else
            {
                Console.WriteLine(days);
            }
        }
    }
}
