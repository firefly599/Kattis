using System;

namespace Volim
{
    class Program
    {
        static void Main(string[] args)
        {
            // Volim
            int player = int.Parse(Console.ReadLine());
            int questions = int.Parse(Console.ReadLine());
            int time = 0;
            for (int i = 0; i < questions; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                time += int.Parse(input[0]);
                if (time > 210)
                {
                    Console.WriteLine(player);
                    break;
                }
                if (input[1] == "T")
                {
                    player++;
                    if (player > 8)
                    {
                        player = 1;
                    }
                }
            }
        }
    }
}
