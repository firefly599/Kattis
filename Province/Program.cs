using System;

namespace Province
{
    class Program
    {
        static void Main(string[] args)
        {
            // Provinces and Gold
            int[] coins = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int power = coins[0] * 3 + coins[1] * 2 + coins[2];
            string buy = "";
            if (power >= 8)
            {
                buy = "Province";
            }
            else if (power >= 5)
            {
                buy = "Duchy";
            }
            else if (power >= 2)
            {
                buy = "Estate";
            }

            if (buy.Length > 1)
            {
                buy += " or ";
            }

            if (power >= 6)
            {
                buy += "Gold";
            }
            else if (power >= 3)
            {
                buy += "Silver";
            }
            else
            {
                buy += "Copper";
            }
            Console.WriteLine(buy);
        }
    }
}
