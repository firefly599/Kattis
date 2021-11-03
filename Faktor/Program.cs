using System;

namespace Faktor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faktor
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Console.WriteLine((numbers[0]*numbers[1]) - numbers[0] + 1);
            // Seems like a stupid question
            // Didnt understand it at all
        }
    }
}
