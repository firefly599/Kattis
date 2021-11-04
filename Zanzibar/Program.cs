using System;

namespace Zanzibar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stand on Zanzibar
            int tests = int.Parse(Console.ReadLine());
            int remove ;
            int import;
            int illegal;
            for (int i = 0; i < tests; i++)
            {
                remove = 1;
                import = 0;
                int[] data = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                for (int j = 0; j < data.Length-1; j++)
                {
                    illegal = data[j] - 2 * remove;;
                    if (illegal > 0)
                    {
                        import += illegal;
                    }
                    remove = data[j];
                }
                Console.WriteLine(import);
            }
        }
    }
}
