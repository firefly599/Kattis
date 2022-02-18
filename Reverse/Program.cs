using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reverse
            int amount = int.Parse(Console.ReadLine());
            double input;
            double[] array = new double[amount];
            for (int i = 0; i < amount; i++)
            {
                input = double.Parse(Console.ReadLine());
                array[i] = input;
            }

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(array[amount-i-1]);
            }
        }
    }
}
