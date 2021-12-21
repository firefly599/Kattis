using System;
using System.Collections.Generic;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parking
            int total;
            int dis;
            int last;
            int[] places;
            int tests = int.Parse(Console.ReadLine());
            List<int> distances = new List<int>();
            for (int i = 0; i < tests; i++)
            {
                dis = 0;
                distances.Clear();
                total = int.Parse(Console.ReadLine());
                places = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                foreach (int place in places)
                {
                    distances.Add(place);
                }
                distances.Sort();
                last = distances[0];
                for (int j = 1; j < distances.Count; j++)
                {
                    dis += distances[j] - last;
                    last = distances[j];
                }
                dis *= 2;
                Console.WriteLine(dis);
            }
        }
    }
}
