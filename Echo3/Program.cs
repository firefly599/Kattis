using System;

namespace Echo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Echo Echo Echo
            string input = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(input + " ");
            }
        }
    }
}
