using System;
using System.Collections.Generic;

namespace Sequence
{
    class Program
    {
        static bool arithmetic(List<int> values)
        {
            int diff = values[1] - values[0];
            for (int i = 1; i < values.Count; i++)
            {
                if (values[i] - values[i -1] != diff)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            // Permuted Arithmetic Sequence
            int[] seq;
            int tests = int.Parse(Console.ReadLine());
            List<int> sequence = new List<int>();
            for (int i = 0; i < tests; i++)
            {
                sequence.Clear();
                seq = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                for (int j = 1; j <= seq[0]; j++)
                {
                    sequence.Add(seq[j]);
                }

                if (arithmetic(sequence))
                {
                    Console.WriteLine("arithmetic");
                    continue;
                }
                sequence.Sort();
                if (arithmetic(sequence))
                {
                    Console.WriteLine("permuted arithmetic");
                }
                else
                {
                    Console.WriteLine("non-arithmetic");
                }
            }
        }
    }
}
