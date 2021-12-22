using System;

namespace Kafkaesque
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kafkaesque
            int stamps = int.Parse(Console.ReadLine());
            int passes = 1;
            int[] numbers = new int[stamps];
            for (int i = 0; i < stamps; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < stamps; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    passes++;
                }
            }
            Console.WriteLine(passes);
        }
    }
}
