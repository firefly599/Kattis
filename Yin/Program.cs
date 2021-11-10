    using System;

namespace Yin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yin and Yang Stones
            string input = Console.ReadLine();
            int black = 0;
            int white = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'W')
                {
                    white++;
                }
                else
                {
                    black++;
                }
            }
            if (white == black)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
