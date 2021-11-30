using System;

namespace Autori
{
    class Program
    {
        static void Main(string[] args)
        {
            // Autori
            string[] name = Console.ReadLine().Split("-");
            string initials = "";
            foreach (string sub in name)
            {
                initials += sub[0];
            }
            Console.WriteLine(initials);
        }
    }
}
