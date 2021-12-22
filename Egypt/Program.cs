using System;

namespace Egypt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Egypt
            string line;
            string[] values;
            double ab;
            double c;
            int[] num = new int[3];
            while ((line = Console.ReadLine()) != "0 0 0")
            {
                values = line.Split(" ");
                for (int i = 0; i < values.Length; i++)
                {
                    num[i] = int.Parse(values[i]);
                }
                Array.Sort(num);
                ab = Math.Pow(num[0], 2) + Math.Pow(num[1], 2);
                c = Math.Pow(num[2], 2);
                if (ab == c)
                {
                    Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("wrong");
                }
            }
        }
    }
}
