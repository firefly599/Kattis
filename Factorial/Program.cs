using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Last Factorial Digit
            int tests = int.Parse(Console.ReadLine());
            int input;
            double total;
            string strVersion;
            for (int i = 0; i < tests; i++)
            {
                total = 1;
                input = int.Parse(Console.ReadLine());
                for (int j = 1; j <= input; j++)
                {
                    total *= j;
                }
                strVersion = total.ToString();
                Console.WriteLine(strVersion[strVersion.Length - 1]);
            }
        }
    }
}
