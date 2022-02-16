using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Finding An A
            string input = Console.ReadLine();
            string copy = input.ToLower();
            int index = copy.IndexOf("a");

            string output = input.Substring(index, input.Length - index);
            Console.WriteLine(output);
        }
    }
}
