using System;

namespace Struggles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contest struggles
            double[] questions = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
            double[] percentage = Array.ConvertAll(Console.ReadLine().Split(" "), double.Parse);
            double remaining = ((questions[0] * percentage[0]) - (questions[1] * percentage[1])) / (questions[0] - questions[1]);
            if (remaining > 100 || remaining < 0)
            {
                Console.WriteLine("impossible");
            }
            else
            {
                Console.WriteLine(remaining);
            }
        }
    }
}
