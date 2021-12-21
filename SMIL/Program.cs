using System;
using System.Collections.Generic;

namespace SMIL
{
    class Program
    {
        static void Main(string[] args)
        {
            // SMIL
            string word = Console.ReadLine();
            word += "holder";
            List<int> places = new List<int>();
            for (int i = 0; i <= word.Length - 3; i++)
            {
                if (word.Substring(i, 2) == ":)" || 
                    word.Substring(i, 2) == ";)" ||
                    word.Substring(i, 3) == ":-)" ||
                    word.Substring(i, 3) == ";-)")
                {
                    places.Add(i);
                }
            }
            foreach (int place in places)
            {
                Console.WriteLine(place);
            }
        }
    }
}
