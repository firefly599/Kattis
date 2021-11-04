using System;

namespace Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Odd Echo
            int words = int.Parse(Console.ReadLine());
            string word;
            for (int i = 0; i < words; i++)
            {
                word = Console.ReadLine();
                if (i % 2 == 0)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
