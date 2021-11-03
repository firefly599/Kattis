using System;

namespace Pot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pot
            int last;
            int input;
            int number = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < number; i++)
            {
                input = int.Parse(Console.ReadLine());
                last = input % 10;
                input = input / 10; 
                total += Math.Pow(input, last);

            }
            Console.WriteLine(total);
        }
    }
}
