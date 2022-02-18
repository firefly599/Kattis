using System;

namespace Skocimis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skocimis
            int[] values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int left = values[1] - values[0]; 
            int right = values[2] - values[1];
            int max = Math.Max(left, right);
            Console.WriteLine(max - 1);
        }
    }
}
