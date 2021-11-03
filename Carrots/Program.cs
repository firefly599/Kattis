using System;

namespace Carrots
{
    class Program
    {
        static void Main(string[] args)
        {

            // Solving for Carrots
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            for (int i = 0; i < numbers[0]; i++)
            {
                Console.ReadLine();
            }
            Console.WriteLine(numbers[1]);
        }
    }
}
