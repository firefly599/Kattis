using System;
using System.Linq;

namespace Conquest
{
    public class Grid
    {
        public bool[,] grid;
        public bool[,] newGrid;
        public int length;
        public int height;

        public Grid (int sizeX, int sizeY)
        {
            this.length = sizeX;
            this.height = sizeY;
            this.grid = new bool[sizeY, sizeX];
            this.newGrid = new bool[sizeY, sizeX];
        }

        public void overridePos(int x, int y)
        {
            this.grid[y, x] = true;
            this.newGrid[y, x] = true;
        }

        public void updateGrid()
        {
            for (int y = 0; y < this.height; y++)
            {
                for (int x = 0; x < this.length; x++)
                {
                    if (this.grid[y, x])
                    {
                        updatePositions(x, y);
                    }
                }
            }
        }

        public void updatePositions(int currentX, int currentY)
        {
            int updateX;
            int offX = 1;
            for (int i = 0; i < 2; i++)
            {
                updateX = currentX + offX;
                if (updateX > -1 && updateX < this.length)
                {
                    this.newGrid[currentY, updateX] = true;
                }
                offX *= -1;
            }
            int updateY;
            int offY = 1;
            for (int i = 0; i < 2; i++)
            {
                updateY = currentY + offY;
                if (updateY > -1 && updateY < this.height)
                {
                    this.newGrid[updateY, currentX] = true;
                }
                offY *= -1;
            }
        }

        public void endDay()
        {
            for (int y = 0; y < this.height; y++)
            {
                for (int x = 0; x < this.length; x++)
                {
                    this.grid[y, x] = this.newGrid[y, x];
                }
            }
        }

        public bool complete()
        {
            for (int y = 0; y < this.height; y++)
            {
                for (int x = 0; x < this.length; x++)
                {
                    if (!(this.grid[y, x]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Conquest Campaign
            int days = 1;
            int[] values = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] pos;
            Grid grid = new Grid(values[0], values[1]);
            
            for (int i = 0; i < values[2]; i++)
            {
                pos = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                grid.overridePos(pos[0] - 1, pos[1] - 1);
            }
            while (true)
            {
                if (grid.complete())
                {
                    break;
                }
                grid.updateGrid();
                grid.endDay();
                days++;
            }
            Console.WriteLine(days);
        }
    }
}
