using System;

namespace Bijele
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bijele
            int[] required = new int[] { 1, 1, 2, 2, 2, 8};
            int[] actual = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] altered = new int [required.Length];
            for (int i = 0; i < required.Length; i++)
            {
                if (actual[i] != required[i])
                {
                    altered[i] = required[i] - actual[i]; 
                }
            }
            foreach (int amount in altered)
            {
                Console.Write("{0} ", amount);
            }
        }
    }
}
