using System;

namespace Easiest
{
    class Program
    {
        static int SumDigits(long number)
        {
            long temp = number;
            long sum = 0;
            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            return (int)sum;
        }
        static void Main(string[] args)
        {
            // The Easiest Problem Is This One
            long np;
            long input;
            int p;
            int nSize;
            int pSize;
            while (true)
            {
                input = long.Parse(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                p = 11;
                nSize = SumDigits(input);

                while (true)
                {
                    np = input * p;
                    pSize = SumDigits(np);
                    if (pSize == nSize)
                    {
                        Console.WriteLine(p);
                        break;
                    }
                    p++;
                }
            }
        }
    }
}
