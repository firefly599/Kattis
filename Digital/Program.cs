using System;

namespace Digital
{
    class Program
    {
        static void Main(string[] args)
        {
            // Digital Display
            string[,] numbers = new string[,] { 
                { "+---+", "|   |", "|   |", "+   +", "|   |", "|   |", "+---+" }, // 0
                { "    +", "    |", "    |", "    +", "    |", "    |", "    +" }, // 1
                { "+---+", "    |", "    |", "+---+", "|    ", "|    ", "+---+" }, // 2
                { "+---+", "    |", "    |", "+---+", "    |", "    |", "+---+" }, // 3
                { "+   +", "|   |", "|   |", "+---+", "    |", "    |", "    +" }, // 4
                { "+---+", "|    ", "|    ", "+---+", "    |", "    |", "+---+" }, // 5
                { "+---+", "|    ", "|    ", "+---+", "|   |", "|   |", "+---+" }, // 6
                { "+---+", "    |", "    |", "    +", "    |", "    |", "    +" }, // 7
                { "+---+", "|   |", "|   |", "+---+", "|   |", "|   |", "+---+" }, // 8
                { "+---+", "|   |", "|   |", "+---+", "    |", "    |", "+---+" }}; // 9
            string input;
            char[] individual;
            int value;
            string[] lines;
            while (true)
            {
                lines = new string[7];
                input = Console.ReadLine();
                individual = input.ToCharArray();
                if (input == "end")
                {
                    Console.WriteLine("end");
                    break;
                }
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < individual.Length; j++)
                    {
                        if (j != 2)
                        {
                            value = individual[j] - '0';
                            
                            lines[i] += numbers[value, i];
                        }
                        else
                        {
                            if (i == 2 || i == 4)
                            {
                                lines[i] += "o";
                            }
                            else
                            {
                                lines[i] += " ";
                            }
                        }
                        if (j != individual.Length - 1)
                        {
                            lines[i] += "  ";
                        }
                        
                    }
                }
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
