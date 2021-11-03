using System;

namespace Planina
{
    class Program
    {
        static void Main(string[] args)
        {
            // Planina
            double number = int.Parse(Console.ReadLine());
            double amount = Math.Pow(2, number)+1;
            amount = Math.Pow(amount, 2);
            Console.WriteLine(amount);

        }
    }
}
