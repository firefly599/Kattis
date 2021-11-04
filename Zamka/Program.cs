using System;

namespace Zamka
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zamka
            int sum;
            int temp;
            int copy;
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = numbers[0]; i <= numbers[1]; i++)
            {
                copy = i;
                sum = 0;
                while (copy > 0)
                {
                    temp = copy % 10;
                    sum = sum + temp;
                    copy /= 10;
                }
                if (sum == numbers[2])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            for (int i = numbers[1]; i >= numbers[0]; i--)
            {
                copy = i;
                sum = 0;
                while (copy > 0)
                {
                    temp = copy % 10;
                    sum = sum + temp;
                    copy /= 10;
                }
                if (sum == numbers[2])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
