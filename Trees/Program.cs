using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            //Planting Trees
            int trees = int.Parse(Console.ReadLine());
            int[] days = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int minimum = 0;
            Array.Sort(days);
            Array.Reverse(days);
            for (int i = 1; i <= trees; i++)
            {
                if (i + days[i-1] > minimum)
                {
                    minimum = days[i-1] + i;
                }
            }
            Console.WriteLine(minimum + 1);
        }
    }
}
