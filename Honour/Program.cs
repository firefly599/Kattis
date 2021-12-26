using System;
using System.Linq;

namespace Honour
{
    class Program
    {
        static void Main(string[] args)
        {
            // Honour Thy (Apaxian) Parent
            string[] input = Console.ReadLine().Split(" ");
            string vowels = "aiou";
            string full;
            string substring;
            if (input[0][input[0].Length - 1] == 'e')
            {
                full = input[0] + "x" + input[1];
            }
            else if (input[0].Substring(input[0].Length - 2, 2) == "ex")
            {
                full = input[0] + input[1];
            }
            else if (vowels.Contains(input[0][input[0].Length - 1]))
            {
                substring = input[0].Substring(0, input[0].Length - 1);
                full = substring + "ex" + input[1];
            }
            else
            {
                full = input[0] + "ex" + input[1];
            }
            Console.WriteLine(full);
        }
    }
}
