using System;

namespace poker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Poker Hand
            string[] hand = Console.ReadLine().Split(" ");
            string values = "A23456789TJQK";
            int max = 0;
            foreach (char value in values)
            {
                int temp = 0;
                foreach (string card in hand)
                {
                    if (card[0] == value)
                    {
                        temp++;
                    }
                }
                if (temp > max)
                {
                    max = temp;
                }
            }
            Console.WriteLine(max);
        }
    }
}
