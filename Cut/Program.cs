using System;
using System.Collections.Generic;

namespace Cut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cut in line
            List<string> order = new List<string>();
            int tests = int.Parse(Console.ReadLine());
            string person;
            for (int i = 0; i < tests; i++)
            {
                person = Console.ReadLine();
                order.Add(person);
            }
            tests = int.Parse(Console.ReadLine());

            string[] action;
            int index;
            for (int i = 0; i < tests; i++)
            {
                action = Console.ReadLine().Split(" ");
                if (action[0] == "cut")
                {
                    index = order.IndexOf(action[2]);
                    order.Insert(index, action[1]);
                }
                else if (action[0] == "leave")
                {
                    index = order.IndexOf(action[1]);
                    order.RemoveAt(index);
                }
            }
            foreach (string people in order)
            {
                Console.WriteLine(people);
            }
        }
    }
}
