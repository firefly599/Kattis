using System;

namespace Relocation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Relocation
            int distance;
            int[] query;
            int[] tests = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] positions = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            for (int i = 0; i < tests[1]; i++)
            {
                query = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                if (query[0] == 1)
                {
                    positions[query[1] - 1] = query[2];
                }
                else if (query[0] == 2)
                {
                    distance = Math.Abs(positions[query[2] - 1] - positions[query[1] - 1]);
                    Console.WriteLine(distance);
                }
            }
        }
    }
}
