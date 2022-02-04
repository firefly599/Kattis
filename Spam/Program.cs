using System;

namespace Spam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alphabet Spam
            char blank = '_';
            string input = Console.ReadLine();
            double length = input.Length;
            double blanks = 0;
            double upper = 0;
            double lower = 0;
            double symbol = 0;

            char current;
            for (int i = 0; i < length; i++)
            {
                current = input[i];
                if (char.IsUpper(current))
                {
                    upper++;
                }
                else if (char.IsLower(current))
                {
                    lower++;
                }
                else if (current == blank)
                {
                    blanks++;
                }
                else
                {
                    symbol++;
                }
            }

            Console.WriteLine(blanks / length);
            Console.WriteLine(lower / length);
            Console.WriteLine(upper / length);
            Console.WriteLine(symbol / length);
        }
    }
}
