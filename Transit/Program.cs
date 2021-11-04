using System;

namespace Transit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Transit Woes
            int[] first = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] second = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] third = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] forth = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int time = 0;
            // idk
            for (int i = 0; i < first[2]; i++)
            {
                time += second[i];
                if (time < forth[i])
                {
                    time += forth[i] - second[i];
                }
                else
                {
                    time += forth[i]*2 - time;
                }
                time += third;
            }
            if (time <= (first[1] - first[0]))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
