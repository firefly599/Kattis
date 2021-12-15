using System;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reversed Binary Numbers
            int num = int.Parse(Console.ReadLine());
            char[] binary = Convert.ToString(num, 2).ToCharArray();
            Array.Reverse(binary);
            string reversed = new string(binary);
            Console.WriteLine(Convert.ToInt32(reversed, 2));
        }
    }
}
