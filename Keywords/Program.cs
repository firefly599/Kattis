using System;
using System.Collections.Generic;

namespace Keywords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Keywords
            HashSet<string> unique = new HashSet<string>();
            int words = int.Parse(Console.ReadLine());
            string input;
            for (int i = 0; i < words; i++)
            {
                input = Console.ReadLine();
                input = input.ToLower();
                while (input.Contains('-'))
                {
                    input = input.Replace('-', ' ');
                }

                if (!unique.Contains(input))
                {
                    unique.Add(input);
                }
            }
            Console.WriteLine(unique.Count);
        }
    }
}
