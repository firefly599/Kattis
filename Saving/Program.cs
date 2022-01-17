using System;

namespace Saving
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saving for retirement
            int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int bob = (input[1] - input[0]) * input[2];
            int alice = 0;
            int age = input[3];
            while (alice <= bob)
            {
                alice += input[4];
                age++;
            }
            Console.WriteLine(age);
        }
    }
}
