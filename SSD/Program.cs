using System;

namespace SSd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum Squared Digits Function
            long number;
            double digitSum;
            int tests = int.Parse(Console.ReadLine());
            long[] values;
            for (int i = 1; i <= tests; i++)
            {
                number = 0;
                digitSum = 0;
                values = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
                while (values[2] > 0)
                {
                    number = values[2] % values[1];
                    digitSum += number * number;
                    values[2] /= values[1];
                }
                Console.WriteLine("{0} {1}", i, digitSum);
            }
        }
    }
}