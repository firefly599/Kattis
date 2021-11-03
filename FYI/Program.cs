using System;

namespace FYI
{
    class Program
    {
        static void Main(string[] args)
        {
            // FYI
            string number = Console.ReadLine();
            string sub = number.Substring(0, 3);
            if (sub == "555")
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
