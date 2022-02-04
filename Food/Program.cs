using System;
using System.Collections.Generic;

namespace Food
{
    class Program
    {
        static void Main(string[] args)
        {
            // Free Food
            int amount = int.Parse(Console.ReadLine());
            int overlap = 0;
            int[] times;
            List<int[]> days = new List<int[]>();
            for (int i = 0; i < amount; i++)
            {
                times = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                days.Add(times);
            }
           
        }
    }
}
