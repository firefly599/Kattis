using System;

namespace Batter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Batter Up
            int no = int.Parse(Console.ReadLine());
            int[] values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            float sum = 0;
            int walks = 0;
            for (int i = 0; i < no; i++)
            {
                if (values[i] != -1)
                { 
                    sum += values[i];
                }
                else
                {
                    walks++;
                }

            }
            sum /= (no - walks);
            Console.WriteLine(sum.ToString("f3"));
        }
    }
}
