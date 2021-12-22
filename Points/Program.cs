using System;
using System.Linq;
using System.Collections.Generic;
namespace Points
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hay points
            Dictionary<string, int> wordScore = new Dictionary<string, int>();
            int score;
            int [] test = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            string[] split;
            string line;
            for (int i = 0; i < test[0]; i++)
            {
                line = Console.ReadLine();
                split = line.Split(" ");
                wordScore.Add(split[0], int.Parse(split[1]));
            }
            for (int i = 0; i < test[1]; i++)
            {
                score = 0;
                while ((line = Console.ReadLine()) != ".")
                {
                    split = line.Split(" ");
                    foreach (string word in split)
                    {
                        if (wordScore.ContainsKey(word))
                        {
                            score += wordScore[word];
                        }
                    }
                    
                }
                Console.WriteLine(score);
            }
        }
    }
}
