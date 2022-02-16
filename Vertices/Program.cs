using System;

namespace Vertices
{
    class Program
    {
        static bool IsNotTriangle(int i, int[,] grid)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                if (grid[j, i] == 1)
                {
                    for (int k = j + 1; k < grid.Length; k++)
                    {
                        Console.WriteLine(k);
                        if (grid[k, i] == 1 && grid[k, j] == 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            // Weak Vertices
            int size;
            int[] connections;
            size = int.Parse(Console.ReadLine());
            while (true) 
            {
                int[,] grid = new int[size, size];
                if (size == -1)
                {
                    break;
                }

                for (int i = 0; i < size; i++)
                {
                    connections = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                    for (int j = 0; j < size; j++)
                    {
                        grid[i, j] = connections[j];
                    }
                }

                for (int i = 0; i < size; i++)
                {
                    if (IsNotTriangle(i, grid))
                    {
                        Console.Write(i + " ");
                    }
                }
                size = int.Parse(Console.ReadLine());
                if (size == -1)
                {
                    break;
                }
                Console.WriteLine("");
            } 
        }
    }
}
