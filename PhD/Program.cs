using System;

namespace PhD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Help a PhD candidate out!
            string eqn;
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                eqn = Console.ReadLine();
                if (eqn == "P=NP")
                {
                    Console.WriteLine("skipped");
                }
                else
                {
                    int[] split = Array.ConvertAll(eqn.Split("+"), int.Parse);
                    Console.WriteLine(split[0] + split[1]);
                }
            }
        }
    }
}
