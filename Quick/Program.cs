using System;
using System.Collections.Generic;

namespace Quick
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quick Brown Fox
            List<char> letters = new List<char>();
            int tests = int.Parse(Console.ReadLine());
            char letter;
            for (int i = 0; i < tests; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    char single = input[j];
                    letter = Char.ToLower(single);
                    letters.Add(letter);
                }

                string missing = "";
                for (int k = 97; k < 97+26; k++)
                {
                    char character = (char)k;
                    if (!(letters.Contains(character)))
                    {
                        missing += character;
                    }
                }
                if (missing == "")
                {
                    Console.WriteLine("pangram");
                }
                else
                {
                    Console.WriteLine("missing " + missing);
                }
                letters.Clear();
            }
        }
    }
}
