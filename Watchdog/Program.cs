using System;

namespace Watchdog
{
    class Program
    {
        static void Main(string[] args)
        {
            // Watchdog
            int tests = int.Parse(Console.ReadLine());
            int[] roof;
            int[] coords;
            for (int test = 0; test < tests; test++)
            {
                roof = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                for (int i = 0; i < roof[1]; i++)
                {
                    coords = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                    for (int x = 0; x < roof[0]; x++)
                    {
                        for (int y = 0; y < roof[0]; y++)
                        {

                        }
                    }
                }
            }
        }
    }
}
