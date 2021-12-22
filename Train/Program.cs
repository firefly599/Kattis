using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            // Train Passengers
            int[] info = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] station;
            int current = 0;
            int capacity = info[0];
            bool possible = true;
            for (int i = 0; i < info[1]; i++)
            {
                station = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                current -= station[0];
                if (current < 0)
                {
                    possible = false;
                    break;
                }
                current += station[1];
                if (current > capacity || (capacity - current > 0 && station[2] > 0) )
                {
                    possible = false;
                    break;
                }
            }
            if (current > 0)
            {
                possible = false;
            }
            if (possible)
            {
                Console.WriteLine("possible");
            }
            else
            {
                Console.WriteLine("impossible");
            }
        }
    }
}
