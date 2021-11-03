using System;

namespace Bela
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bela
            string given;
            string[] card;
            string[] hand = Console.ReadLine().Split(" ");
            int score = 0;
            int size = int.Parse(hand[0]) * 4;
            for (int i = 0; i < size; i++)
            {
                given = Console.ReadLine();
                card = new string[2];
                
                card[0] = given.Substring(0, 1);
                card[1] = given.Substring(1, 1);
                if (card[0] == "A")
                {
                    score += 11;
                }
                else if (card[0] == "K")
                {
                    score += 4;
                }
                else if (card[0] == "Q")
                {
                    score += 3;
                }
                else if (card[0] == "J" && card[1] == hand[1])
                {
                    score += 20;
                }
                else if (card[0] == "J")
                {
                    score += 2;
                }
                else if (card[0] == "T")
                {
                    score += 10;
                }
                else if (card[0] == "9" && card[1] == hand[1])
                {
                    score += 14;
                }
                
            }
            Console.WriteLine(score);
        }
    }
}
