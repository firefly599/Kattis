using System;
using System.Collections.Generic;

namespace Food
{
    class Program
    {
        static void Main(string[] args)
        {
            // Free Food
            int amount = int.Parse(Console.ReadLine());
            int a;
            int b;
            int total = 0;
            int[] values;
            bool[] days = new bool[400];
           
            for (int t = 0; t < amount; t++)
            {
                values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                a = values[0];
                b = values[1];
                for (int i = a; i <= b; i++)
                {
                    days[i] = true;
                }
            }

            for (int i = 0; i < days.Length; i++)
            {
                if (days[i])
                {
                    total++;
                }
            }
            Console.WriteLine(total);
        }
    }
}
