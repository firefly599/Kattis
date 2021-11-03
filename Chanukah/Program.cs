using System;

namespace Chanukah
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chanukah Challenge
            int total;
            int sets = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sets; i++)
            {
                total = -1;
                int[] days = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                for (int j = 0; j <= days[1]+1; j++)
                {
                    total += j;
                }
                Console.WriteLine(i + " " + total);
            }
        }
    }
}
