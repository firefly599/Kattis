using System;

namespace Conundrum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cryptographer's Conundrum
            string input = Console.ReadLine();
            input = input.ToLower();
            int counter = 0;
            string per = "per";
            for (int i = 0; i < input.Length-2; i += 3)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (!(input[i+j] == per[j]))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
