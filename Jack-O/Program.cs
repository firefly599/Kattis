using System;

namespace Jack_O
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jack-O'-Lantern Juxtaposition
            int total = 1;
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            foreach (var num in numbers)
            {
                total *= num;
            }
            Console.WriteLine(total);
        }
    }
}
