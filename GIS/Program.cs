using System;
using System.Collections.Generic;
namespace GIS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greedily Increasing Subsequence
            int numbers = int.Parse(Console.ReadLine());
            int[] values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            List<int> sub = new List<int>();
            sub.Add(values[0]);
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > sub[sub.Count - 1])
                {
                    sub.Add(values[i]);
                }
            }
            Console.WriteLine(sub.Count);
            foreach (int value in sub)
            {
                Console.Write("{0} ", value);
            }
        }
    }
}
