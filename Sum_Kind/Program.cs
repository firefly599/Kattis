using System;

namespace Sum_Kind
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum Kind of Problem
            int tests = int.Parse(Console.ReadLine());
            int[] data;
            long s1;
            long s2;
            long s3;
            for (int i = 0; i < tests; i++)
            {
                data = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                s1 = data[1] * (data[1] + 1) / 2;
                s2 = data[1] * data[1];
                s3 = data[1] * (data[1] + 1);
                Console.WriteLine("{0} {1} {2} {3}", data[0], s1, s2, s3);
            }
        }
    }
}
