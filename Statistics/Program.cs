using System;
using System.Collections.Generic;

namespace Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Statistics
            int cases = 1;
            int min;
            int max;
            int dif;
            string line;
            string[] split;
            List<int> values = new List<int>();
            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                values.Clear();
                split = line.Split(" ");
                for (int i = 1; i < split.Length; i++)
                {
                    values.Add(int.Parse(split[i]));
                }
                values.Sort();
                min = values[0];
                max = values[values.Count - 1];
                dif = max - min;
                Console.WriteLine("Case {0}: {1} {2} {3}", cases, min, max, dif);
                cases++;
            }
        }
    }
}
