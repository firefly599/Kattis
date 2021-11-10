using System;

namespace Odd_Man
{
    class Program
    {
        static void Main(string[] args)
        {
            // Odd Man Out
            int tests = int.Parse(Console.ReadLine());
            for (int i = 1; i <= tests; i++)
            {
                int guests = int.Parse(Console.ReadLine());
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                for (int j = 0; j < guests; j++)
                {
                    bool matching = false;
                    for (int k = 0; k < guests; k++)
                    {
                        if (j != k)
                        {
                            if (numbers[j] == numbers[k])
                            {
                                matching = true;
                                break;
                            }
                        }
                    }
                    if (!matching)
                    {
                        Console.WriteLine("Case #{0}: {1}", i, numbers[j]);
                    }
                }
            }
        }
    }
}
