using System;

namespace Chicken
{
    class Program
    {
        static void Main(string[] args)
        {
            // One Chicken Per Person!
            int[] amount = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int difference = amount[1] - amount[0];
            if (difference > 1)
            {
                Console.WriteLine("Dr. Chaz will have {0} pieces of chicken left over!", difference);
            }
            else if (difference == 1)
            {
                Console.WriteLine("Dr. Chaz will have {0} piece of chicken left over!", difference);
            }
            else if (difference == -1)
            {
                Console.WriteLine("Dr. Chaz needs {0} more piece of chicken!", Math.Abs(difference));
            }
            else
            {
                Console.WriteLine("Dr. Chaz needs {0} more pieces of chicken!", Math.Abs(difference));
            }
        }
    }
}
