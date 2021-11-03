using System;

namespace N_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // N-sum
            int total = 0;
            int amount = int.Parse(Console.ReadLine());
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            foreach (var num in numbers)
            {
                total += num;
            }
            Console.WriteLine(total);
        }
    }
}
