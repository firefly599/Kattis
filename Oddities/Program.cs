using System;

namespace Oddities
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oddities
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("{0} is even", number);
                }
                else
                {
                    Console.WriteLine("{0} is odd", number);
                }
            }
        }
    }
}
