using System;
using System.Collections.Generic;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum of the Others
            List<string> temp = new List<string>();
            List<string> original = new List<string>();
            string[] input;
            string line;
            int total;
            int target;
            string current;
            while (!string.IsNullOrEmpty((line = Console.ReadLine())))
            {
                original.Clear();
                input = line.Split(" ");
                foreach (string item in input)
                {
                    original.Add(item);
                }
                
                for (int i = 0; i < original.Count; i++)
                {
                    
                    temp.Clear();
                    foreach (string obj in original)
                    {
                        temp.Add(obj);
                    }

                    target = int.Parse(temp[i]);
                    temp.RemoveAt(i);
                    total = 0;
                    for (int j = 0; j < temp.Count; j++)
                    {
                        current = temp[j];
                        if (temp[j][0] == '-')
                        {
                            current = temp[j].Substring(1);
                            total -= int.Parse(current);
                        }
                        else
                        {
                            total += int.Parse(current);
                        }
                    
                    }
                    if (total == target)
                    {
                        Console.WriteLine(total);
                        break;
                    }

                }
            }
        }
    }
}
