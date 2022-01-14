using System;
using System.Linq;
using System.Collections.Generic;

namespace Recount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recount
            string line;
            List<string> names = new List<string>();
            List<int> votes = new List<int>();
            int index = 0;
            while ((line = Console.ReadLine()) != "***")
            {
                if (names.Contains(line))
                {
                    index = names.IndexOf(line);
                    votes[index] += 1;
                }
                else
                {
                    names.Add(line);
                    votes.Add(1);
                }
            }
            int max = votes.Max();
            int first = votes.FindIndex(0, votes.Count, x => x==max);
            int second = votes.FindIndex(first+1, votes.Count - first - 1, x => x==max);

            if (second == -1)
            {
                Console.WriteLine(names[first]);
            }
            else
            {
                Console.WriteLine("Runoff!");
            }

        }
    }
}
