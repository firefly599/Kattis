using System;
using System.Linq;
using System.Collections.Generic;
namespace Watchdog
{
    class Program
    {
        static double GetDistance(int x1, int x2, int y1, int y2)
        {
            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return d;
        }

        static void Main(string[] args)
        {
            // Watchdog
            int tests = int.Parse(Console.ReadLine());
            int[] roof;
            List<int[]> positions = new List<int[]>();
            int[] coords;
            int[] current;
            int[] final = new int[2];
            int index;
            double distance;
            
            for (int test = 0; test < tests; test++)
            {
                roof = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                positions.Clear();
                for (int i = 0; i < roof[1]; i++)
                {
                    coords = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                    positions.Add(coords);
                }

                for (int x = 0; x < roof[0]; x++)
                {

                }
                foreach (int[] pair in positions)
                {
                    max = 
                }

                if (finished)
                {
                    index = amount.IndexOf(amount.Max());
                    Console.WriteLine("{0} {1}", duplicates[index][0], duplicates[index][1]);
                }
                else
                {
                    Console.WriteLine("poodle");
                }
            }
        }
    }
}
