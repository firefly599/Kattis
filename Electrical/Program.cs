using System;

namespace Electrical
{
    class Program
    {
        static void Main(string[] args)
        {
            // Electrical Outlets
            int amount = int.Parse(Console.ReadLine());
            int count;
            for (int i = 0; i < amount; i++)
            {
                count = 0;
                int[] strips = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                for (int j = 1; j < strips.Length; j++)
                {
                    if (j == strips.Length - 1)
                    {
                        count += strips[j];
                    }
                    else
                    {
                        count += strips[j] - 1;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
