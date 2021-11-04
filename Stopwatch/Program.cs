using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stopwatch
            
            int time = 0;
            int stops = int.Parse(Console.ReadLine());
            int[] times = new int[stops];
            for (int i = 0; i < stops; i++)
            {
                times[i] = int.Parse(Console.ReadLine());
            }
            if (times.Length > 1)
            {
                for (int i = 1; i < times.Length; i+= 2)
                {
                    time += times[i] - times[i-1];
                }
            }
            if (stops % 2 == 0)
            {
                Console.WriteLine(time);
            }
            else
            {
                Console.WriteLine("still running");
            }
        }
    }
}
