using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greetings!
            string input = Console.ReadLine();
            int length = input.Length;
            string head = input.Substring(0, 1);
            string body = input.Substring(1, (length - 2));
            string tail = input.Substring((length - 1), 1);
            string doubled = head + body + body + tail;
            Console.WriteLine(doubled);
        }
    }
}
