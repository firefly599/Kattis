using System;

namespace Kornislav
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kornislav
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Array.Sort(numbers);
            Console.WriteLine(numbers[0]*numbers[2]);
        }
    }
}
