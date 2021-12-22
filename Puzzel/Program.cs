using System;

namespace Puzzel
{
    class Program
    {
        static void Main(string[] args)
        {
            // N-Puzzle
            string line;
            int distance = 0;
            int[] target = new int[2];
            string[] board = new string[] { "ABCD", "EFGH", "IJKL", "MNO." };
            bool found;
            for (int i = 0; i < 4; i++)
            {
                line = Console.ReadLine();
                for (int letter = 0; letter < 4; letter++) 
                {
                    found = false;
                    for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (board[j][k] == line[letter])
                            {
                                target[0] = j;
                                target[1] = k;
                                found = true;
                                break;
                            }
                        }
                        if (found)
                        {
                            break;
                        }
                    }
                    distance += Math.Abs(target[0] - i) + Math.Abs(target[1] - letter);
                }
            }
            Console.WriteLine(distance / 2);
        }
    }
}
