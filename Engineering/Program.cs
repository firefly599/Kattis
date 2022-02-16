using System;
using System.Collections.Generic;

namespace Engineering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Engineering English
            HashSet<string> dictionary = new HashSet<string>();
            string[] split;
            string word;
            string line;
            string output = "";
            while (string.IsNullOrEmpty(line = Console.ReadLine())) // string.IsNullOrEmpty(line = Console.ReadLine())
            {
                split = line.Split(" ");
                for (int i = 0; i < split.Length; i++)
                {
                    word = split[i];
                    word = word.ToLower();
                    if (!dictionary.Contains(word))
                    {
                        dictionary.Add(word);
                        output += split[i];
                    }
                    else
                    {
                        output += ".";
                    }
                    output += " ";
                }
                output += "\n";
            }
            output = output.Substring(0, output.Length - 2);
            Console.WriteLine(output);
        }
    }
}
