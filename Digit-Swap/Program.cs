using System;

namespace Digit_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Digit Swap
            int input = int.Parse(Console.ReadLine());
            int result = 0;
            while (input > 0)
            {
                result = result*10 + input % 10;
                input /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
