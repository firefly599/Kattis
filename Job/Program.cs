using System;

namespace Job
{
    class Program
    {
        static void Main(string[] args)
        {
            // Job Expenses
            int tests = int.Parse(Console.ReadLine());
            if (tests != 0)
            { 
                int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int total = 0;
                foreach (int value in numbers)
                {
                    if (value < 0)
                    {
                        total += (value * -1);
                    }
                }
                Console.WriteLine(total);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
