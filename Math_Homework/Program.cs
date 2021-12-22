using System;

namespace Math_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math Homework
            int[] legs = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int total = 0;
            for (int i = 0; i <= (legs[3] / legs[0]); i++)
            {
                for (int j = 0; j <= (legs[3] / legs[1]); j++)
                {
                    for (int k = 0; k <= (legs[3] / legs[2]); k++)
                    {
                        if ((legs[0] * i + legs[1] * j + legs[2] * k) == legs[3])
                        {
                            Console.WriteLine("{0} {1} {2}", i, j, k);
                            total++;
                        }
                    }
                }
            }
            if (total == 0)
            {
                Console.WriteLine("impossible");
            }
        }
    }
}
