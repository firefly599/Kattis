using System;
using System.Collections.Generic;
namespace Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Costume Contest
            List<string> costumes = new List<string>();
            List<int> costumeAmount = new List<int>();
            List<string> output = new List<string>();
            int amount = int.Parse(Console.ReadLine());
            string costume;
            for (int i = 0; i < amount; i++)
            {
                costume = Console.ReadLine();
                if (costumes.Contains(costume))
                {
                    costumeAmount[costumes.IndexOf(costume)] += 1;
                }
                else
                {
                    costumes.Add(costume);
                    costumeAmount.Add(1);
                }
            }
            int min = 10000;
            for (int i = 0; i < costumes.Count; i++)
            {
                if (costumeAmount[i] < min)
                {
                    output.Clear();
                    min = costumeAmount[i];
                    output.Add(costumes[i]);
                }
                else if (costumeAmount[i] == min)
                {
                    output.Add(costumes[i]);
                }
            }
            output.Sort();
            foreach (string item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
