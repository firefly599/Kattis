using System;
using System.Linq;

namespace Mia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mia
            string line;
            string[] dice;
            int[] player1 = new int[2];
            int[] player2 = new int[2];
            int score1;
            int score2;
            while ((line = Console.ReadLine()) != "0 0 0 0")
            {
                score1 = 10;
                score2 = 10;

                dice = line.Split(" ");
                for (int i = 0; i < 4; i++)
                {
                    if (i < 2)
                    {
                        player1[i] = int.Parse(dice[i]); 
                    }
                    else
                    {
                        player2[i-2] = int.Parse(dice[i]); 
                    }
                }
                Array.Sort(player1);
                Array.Sort(player2);
                int[] top = new int[] { 1, 2};
                // Checks if the player got the top score
                if (Enumerable.SequenceEqual(player1, top))
                {
                    score1 = 0;
                }
                // CHecks if duplicates values and assign score
                else if (player1[0] == player1[1])
                {
                    score1 = 7 - player1[0];
                }
                if (Enumerable.SequenceEqual(player2, top))
                {
                    score2 = 0;
                }
                else if (player2[0] == player2[1])
                {
                    score2 = 7 - player2[0];
                }

                if (score1 == 10 && score2 == 10)
                {
                    if (player1[1] > player2[1])
                    {
                        score1 = 0;
                        score2 = 1;
                    }
                    else if (player1[1] == player2[1])
                    {
                        if (player1[0] > player2[0])
                        {
                            score1 = 0;
                            score2 = 1;
                        }
                        else if (player1[0] == player2[0])
                        {
                            score1 = 0; 
                            score2 = 0;
                        }
                        else
                        {
                            score1 = 1;
                            score2 = 0;
                        }
                    }
                    else
                    {
                        score1 = 1;
                        score2 = 0;
                    }
                }

                if (score1 < score2)
                {
                    Console.WriteLine("Player 1 wins.");
                }
                else if (score1 == score2)
                {
                    Console.WriteLine("Tie.");
                }
                else
                {
                    Console.WriteLine("Player 2 wins.");
                }
            }
        }
    }
}