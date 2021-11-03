using System;

namespace Dice_Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dice Cup
            int[] dice = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            if (dice[1] < dice[0])
            {
                int temp = dice[0];
                dice[0] = dice[1];
                dice[1] = temp;
            }
            for (int i = (dice[0] + 1); i <= (dice[1]+1); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
