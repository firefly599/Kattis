using System;

namespace Bishops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string input;
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                num = int.Parse(input);
                if (num > 1)
                {
                    Console.WriteLine(num + num - 2);
                }
                else
                {
                    Console.WriteLine("1");
                }
            }
        }
    }
}
