using System;

namespace pet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pet
            int highest = 0;
            int pos = 0;
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                int[] line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                sum = 0;
                foreach(int value in line)
                {
                    sum += value;
                }
                if (sum > highest)
                {
                    highest = sum;
                    pos = i;
                }
            }
            Console.WriteLine("{0} {1}", pos, highest);
        }
    }
}
