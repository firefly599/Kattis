using System;

namespace Trik
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trik
            string moves = Console.ReadLine();
            int pos = 1;
            for (int i = 0; i < moves.Length; i++)
            {
                if (pos == 1 && moves[i] == 'A')
                {
                    pos = 2;
                }
                else if (pos == 1 && moves[i] == 'C')
                {
                    pos = 3;
                }
                else if (pos == 2 && moves[i] == 'B')
                {
                    pos = 3;
                }
                else if (pos == 2 && moves[i] == 'A')
                {
                    pos = 1;
                }
                else if (pos == 3 && moves[i] == 'C')
                {
                    pos = 1;
                }
                else if (pos == 3 && moves[i] == 'B')
                {
                    pos = 2;
                }
            }
            Console.WriteLine(pos);
        }
    }
}
