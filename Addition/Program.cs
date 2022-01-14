using System;
using System.Numerics;

namespace addition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Addition
            string no1 = Console.ReadLine();
            string no2 = Console.ReadLine();
            BigInteger sum = BigInteger.Parse(no1) + BigInteger.Parse(no2);
            Console.WriteLine(sum);
        }
    }
}
