using System;
using System.Collections.Generic;

namespace Popular
{
    class Program
    {
        static void Main(string[] args)
        {
            // Popular Vote
            int tests = int.Parse(Console.ReadLine());
            int totalCandidates;
            int max;
            int leading;
            int votes;
            int totalVotes;
            List<int> candidates = new List<int>();
            bool matching;
            for (int i = 0; i < tests; i++)
            {
                candidates.Clear();
                totalCandidates = int.Parse(Console.ReadLine());
                max = -1;
                leading = -1;
                totalVotes = 0;
                matching = false;
                for (int j = 0; j < totalCandidates; j++)
                {
                    votes = int.Parse(Console.ReadLine());
                    totalVotes += votes;
                    if (votes > max)
                    {
                        leading = j;
                        max = votes;
                        matching = false;
                    }
                    else if (votes == max)
                    {
                        matching = true;
                    }
                }
                if (matching)
                {
                    Console.WriteLine("no winner");
                }
                else if (max <= totalVotes / 2)
                {
                    Console.WriteLine("minority  winner {0}", leading + 1);
                }
                else
                {
                    Console.WriteLine("majority winner {0}", leading + 1);
                }
            }
        }
    }
}
