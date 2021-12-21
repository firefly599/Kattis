using System;

namespace Forced
{
    class Program
    {
        static void Main(string[] args)
        {
            // Forced Choice
            int[] nps = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            bool keep;
            for (int i = 0; i < nps[2]; i++)
            {
                keep = false;
                int[] cards = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                for (int j = 1 ; j <= cards[0]; j++)
                {
                    if (cards[j] == nps[1])
                    {
                        keep = true;
                    }
                }
                if (keep)
                {
                    Console.WriteLine("KEEP");
                }
                else
                {
                    Console.WriteLine("REMOVE");
                }
            }
        }
    }
}
