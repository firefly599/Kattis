using System;

namespace Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Magic Trick
            string contains = "";
            string input = Console.ReadLine();
            bool pos = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (!(contains.Contains(input[i])))
                {
                    contains += input[i];
                }
                else
                {
                    pos = false;
                    break;
                }
            }
            if (pos)
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
