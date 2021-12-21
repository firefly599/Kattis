using System;

namespace Harshad
{
    class Program
    {
        static void Main(string[] args)
        {
            // Harshad Number
            int sum = 0;
            int total = int.Parse(Console.ReadLine());
            int temp;
            while (true)
            { 
                sum = 0;
                temp = total;
                while (temp != 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }
                if (total % sum == 0)
                {
                    Console.WriteLine(total);
                    break;
                }
                else
                {
                    total++;
                }
            }
        }
    }
}
