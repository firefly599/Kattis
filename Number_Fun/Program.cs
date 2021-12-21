using System;

namespace Number_Fun
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number fun
            int tests = int.Parse(Console.ReadLine());
            double[] numbers;
            bool pos;
            for (int i = 0; i < tests; i++)
            {
                pos = false;
                numbers = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
                if (numbers[0] + numbers[1] == numbers[2])
                {
                    pos = true;
                }
                else if (numbers[0] - numbers[1] == numbers[2])
                {
                    pos = true;
                }
                else if (numbers[1] - numbers[0] == numbers[2])
                {
                    pos = true;
                }
                else if (numbers[0] * numbers[1] == numbers[2])
                {
                    pos = true;
                }
                else if (numbers[0] / numbers[1] == numbers[2])
                {
                    pos = true;
                }
                else if (numbers[1] / numbers[0] == numbers[2])
                {
                    pos = true;
                }

                if (pos)
                {
                    Console.WriteLine("Possible");
                }
                else
                {
                    Console.WriteLine("Impossible");
                }
            }
        }
    }
}
