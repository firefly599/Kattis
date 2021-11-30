using System;
using System.Collections.Generic;

namespace Apax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apaxiaaaaaaaaaaaans!
            string word = Console.ReadLine();
            List<char> converted = new List<char>();
            converted.Add(word[0]);
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] != word[i - 1])
                {
                    converted.Add(word[i]);
                }
            }
            Console.WriteLine(new string(converted.ToArray()));
        }
    }
}
