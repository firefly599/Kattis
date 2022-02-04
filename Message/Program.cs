using System;

namespace Message
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encoded Message
            int amount = int.Parse(Console.ReadLine());
            for (int times = 0; times < amount; times++)
            {
                int index = 0;
                string input = Console.ReadLine();
                int size = (int)Math.Sqrt(input.Length);
                char [,] matrix = new char[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        matrix[i, j] = input[index];
                        index++;
                    }
                }



                char[,] temp = new char[2, 2];
                for (int i = 0; i < size; i++)
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        if (i < j)
                        {
                            temp[0, 0] = matrix[i, j];
                            matrix[i, j] = matrix[j, i];
                            matrix[j, i] = temp[0, 0];
                        }
                    }
                }


                for (int j = 0; j < size; j++)
                {
                    for (int i = 0; i < size/2; i++)
                    {
                        temp[0, 0] = matrix[i, j];
                        matrix[i, j] = matrix[size-1-i, j];
                        matrix[size-1-i, j] = temp[0, 0];
                    }
                }
                string output = "";
                foreach (char letter in matrix)
                {
                    output += letter;
                }
                Console.WriteLine(output);
            }
        }
    }
}
