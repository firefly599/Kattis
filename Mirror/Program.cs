using System;

namespace mirror
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mirror Images
            int tests = int.Parse(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                int[] sizes = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                string[] lines = new string[sizes[0]];
                Console.WriteLine("Test {0}", i+1);
                for (int j = 0; j < sizes[0]; j++)
                {
                    lines[j] = Console.ReadLine();
                }

                for (int j = lines.Length-1; j >= 0; j--)
                {
                    char[] array = lines[j].ToCharArray();
                    Array.Reverse(array);
                    Console.WriteLine(new string (array));
                    
                }
            }
        }
    }
}
