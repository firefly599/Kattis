using System;

namespace Backspace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Backspace
            string input = Console.ReadLine();
            string copy = input;
            int amount = copy.Split('<').Length - 1;

            int index;
            for (int i = 0; i < amount; i++)
            {
                index = input.IndexOf('<') - 1;
                input = input.Remove(index, 2);
            }
            Console.WriteLine(input);
            
        }
    }
}
