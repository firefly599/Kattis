using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mixed Fractions
            int[] values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int whole;
            int remainder;
            while (values[0] != 0 && values[1] != 0)
            {
                
                whole = values[0] / values[1];
                remainder = values[0] % values[1];
                Console.WriteLine("{0} {1} / {2}", whole, remainder, values[1]);
                values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            }
        }
    }
}
