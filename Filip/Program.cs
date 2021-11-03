using System;

namespace Filip
{
    class Program
    {
        static void Main(string[] args)
        {
            // Filip
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] sorted = new int[2];
            int pos = 0;
            foreach (int num in numbers)
            {
                int result = 0;
                int value = num;
                // Stolen from the web
                // Reverses a number
                while (value > 0)
                {
                    result = result * 10 + value % 10;
                    value /= 10;
                }
                sorted[pos] = result;
                pos++;
            }
            if (sorted[0] < sorted[1])
            {
                Console.WriteLine(sorted[1]);
            }
            else
            {
                Console.WriteLine(sorted[0]);
            }
        }
    }
}
