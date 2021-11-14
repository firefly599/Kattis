using System;
using System.Collections.Generic;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parking
            int total = 0;
            int[] starts = new int[3];
            int[] ends = new int[3];
            int[] prices = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] times = new int[3];
            for (int i = 0; i < 3; i++)
            {
                times = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                starts[i] = times[0];
                ends[i] = times[0] + times[1];
            }
            Array.Sort(starts);
            Array.Sort(ends);


        }
    }
}
