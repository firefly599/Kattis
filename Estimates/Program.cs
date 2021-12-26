using System;

namespace Estimates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quick Estimates
            int test = int.Parse(Console.ReadLine());
            string number;
            for (int i = 0; i < test; i++)
            {
                number = Console.ReadLine();
                Console.WriteLine(number.Length);
            }
        }
    }
}
