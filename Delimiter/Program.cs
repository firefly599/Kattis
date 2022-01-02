using System;
using System.Collections.Generic;

namespace Delimiter
{
    class Program
    {
        static bool checkInStack(char current, List<char> stack)
        {
            if (stack.Count == 0)
            {
                return false;
            }
            else
            {
                int last = stack.Count - 1;
                if (current == stack[last])
                {
                    return true;
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
            // Delimiter Soup
            List<char> stack = new List<char>();
            int tests = int.Parse(Console.ReadLine());
            int pos;
            string input = Console.ReadLine();
            string opening = "([{";
            string closing = ")]}";
            char current;
            bool terminated = false;
            for (int i = 0; i < tests; i++)
            {
                current = input[i];
                if (closing.Contains(current))
                {
                    if (checkInStack(current, stack))
                    {
                        stack.RemoveAt(stack.Count - 1);
                    }
                    else
                    {
                        terminated = true;
                        Console.WriteLine("{0} {1}", current, i);
                        break;
                    }
                }
                else if (opening.Contains(current))
                {
                    pos = opening.IndexOf(current);
                    stack.Add(closing[pos]);
                }
            }
            if (!terminated)
            {
                Console.WriteLine("ok so far");
            }
            
        }
    }
}
