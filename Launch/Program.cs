using System;

namespace Launch
{
    class Program
    {
        static void Main(string[] args)
        {
            // License to Launch
            int tests = int.Parse(Console.ReadLine());
            int[] junk = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            double lowest = 9999999999;
            int day = 0;
            for (int i = 0; i < junk.Length; i++)
            {
                if (junk[i] < lowest)
                {
                    day = i;
                    lowest = junk[i];
                }
            }
            Console.WriteLine(day);
        }
    }
}
