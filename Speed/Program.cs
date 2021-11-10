using System;

namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Speed Limit
            int speeds;
            int last;
            int distance;
            do
            {
                speeds = int.Parse(Console.ReadLine());
                if (speeds == -1)
                {
                    break;
                }
                last = 0;
                distance = 0;
                for (int i = 0; i < speeds; i++)
                {
                    int[] values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                    distance += values[0] * (values[1] - last);
                    last = values[1];
                }
                Console.WriteLine(distance + " miles");
            } while (speeds != -1);
        }
    }
}
