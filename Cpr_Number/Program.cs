using System;

namespace Cpr_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // CPR Number
            string multiple = "4327654321";
            string input = Console.ReadLine();
            input = input.Remove(6, 1);
            int total = 0;
            int temp;
            for (int i = 0; i < 10; i++)
            {
                temp = ((int)multiple[i] - '0') * ((int)input[i] - '0');
                total += temp;
            }
            if (total % 11 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
