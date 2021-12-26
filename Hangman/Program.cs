using System;
using System.Linq;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hangman
            int amount = 0;
            int correct = 0;
            int incorrect = 0;
            char[] word = Console.ReadLine().ToCharArray();
            string order = Console.ReadLine();
            bool win = false;
            bool present;

            // Loops over each letter guessed
            foreach (char guess in order)
            {
                present = false;    
                amount = 0;
                // Loops over each letter in the word
                foreach (char letter in word)
                {
                    // If the letter exists increment a present counter
                    if (letter == guess)
                    {
                        present = true;
                        amount++;
                    }
                }
                // If the letter is present increment the amount of total correct letters
                if (present)
                {
                    correct += amount;
                }
                else
                {
                    incorrect++;
                }
                // If total correct letters matches the word length then they have won
                if (correct == word.Length)
                {
                    win = true;
                    break;
                }
                // If user guessed more than 10 times they lose
                else if (incorrect >= 10)
                {
                    win = false;
                    break;
                }
            }

            if (win)
            {
                Console.WriteLine("WIN");
            }
            else
            {
                Console.WriteLine("LOSE");
            }
        }
    }
}
