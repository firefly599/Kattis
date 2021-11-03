using System;

namespace Take_Two_Stones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take Two Stones
            int stones = int.Parse(Console.ReadLine());
            if (stones % 2 == 0)
            {
                Console.WriteLine("Bob");
            }
            else
            {
                Console.WriteLine("Alice");
            }
        }
    }
}
