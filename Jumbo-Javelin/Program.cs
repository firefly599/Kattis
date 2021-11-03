using System;

namespace Jumbo_Javelin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jumbo Javelin
            int length = 0;
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                length += int.Parse(Console.ReadLine());
            }
            length -= amount - 1;
            Console.WriteLine(length);
        }
    }
}
