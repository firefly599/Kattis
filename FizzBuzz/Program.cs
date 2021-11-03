using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // FizzBuzz
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            for (int i = 1; i <= numbers[2]; i++)
            {
                if ((i % numbers[0] == 0) && (i % numbers[1] == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % numbers[0] == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % numbers[1] == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
  
        }
    }
}
