using System;
using System.Collections.Generic;

namespace ragged
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rgged Right
            string input;
            List<string> lines = new List<string>();
            int max = 0;
            double score = 0;
            int length;
            while(!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                lines.Add(input);
                length = input.Length;
                if (length > max)
                {
                    max = length;
                }
            }
            for (int i = 0; i < lines.Count - 1; i++)
            {
                length = lines[i].Length;
                score += Math.Pow((max - length), 2);
            }
            Console.WriteLine(score);
        }
    }
}
