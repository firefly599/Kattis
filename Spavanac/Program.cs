using System;

namespace Spavanac
{
    class Program
    {
        static void Main(string[] args)
        {
            // Spavanac
            int[] time = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            time[1] -= 45;
            if (time[1] < 0)
            {
                time[1] = 60 + time[1];
                time[0]--;
                if (time[0] < 0)
                {
                    time[0] = 23;
                }
            }
            Console.WriteLine(time[0] + " " + time[1]);
        }
    }
}
