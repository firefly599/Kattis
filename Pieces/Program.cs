using System;

namespace pieces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Piece of Cake!
            int[] sizes = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int piece1 = sizes[1] * sizes[2] * 4;
            int piece2 = (sizes[0] - sizes[1]) * sizes[2] * 4;
            int piece3 = sizes[1] * (sizes[0] - sizes[2]) * 4;
            int piece4 = (sizes[0] - sizes[1]) * (sizes[0] - sizes[2]) * 4;
            int large1 = Math.Max(piece1, piece2);
            int large2 = Math.Max(piece3, piece4);
            Console.WriteLine(Math.Max(large1, large2));
        }
    }
}
