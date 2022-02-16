using System;

namespace Cudoviste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cudoviste
            int cars;
            int[] size = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] crushed = new int[5];
            string[] grid = new string[size[0]];
            string line;
            bool building;

            for (int i = 0; i < size[0]; i++)
            {
                line = Console.ReadLine();
                grid[i] = line;
            }
            
            for (int x = 0; x < size[0] - 1; x++)
            {
                for (int y = 0; y < size[1] - 1; y++)
                {
                    building = false;
                    cars = 0;
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (grid[x+i][y+j] == '#')
                            {
                                building = true;
                            }
                            else if (grid[x+i][y+j] == 'X')
                            {
                                cars++;
                            }
                        }
                    }
                    if (building)
                    {
                        continue;
                    }
                    else
                    {
                        crushed[cars]++;
                    }
                }
            }
            foreach (int amount in crushed)
            {
                Console.WriteLine(amount);
            }
        }
    }
}
