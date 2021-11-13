using System;

namespace T9
{
    class Program
    {
        static void Main(string[] args)
        {
            // T9 Spelling
            string[,] values = new string[,]
            {
                {"a", "2"},
                {"b", "22"},
                {"c", "222"},
                {"d", "3"},
                {"e", "33"},
                {"f", "333"},
                {"g", "4"},
                {"h", "44"},
                {"i", "444"},
                {"j", "5"},
                {"k", "55"},
                {"l", "555"},
                {"m", "6"},
                {"n", "66"},
                {"o", "666"},
                {"p", "7"},
                {"q", "77"},
                {"r", "777"},
                {"s", "7777"},
                {"t", "8"},
                {"u", "88"},
                {"v", "888"},
                {"w", "9"},
                {"x", "99"},
                {"y", "999"},
                {"z", "9999"},
                {" ", "0"}};

            int tests = int.Parse(Console.ReadLine());
            char last = 'a';
            string converted;
            string added;
            for (int i = 1; i <= tests; i++)
            {
                string word = Console.ReadLine();
                converted = "";
                for (int j = 0; j < word.Length; j++)
                {
                    for (int k = 0; k < values.Length; k++)
                    {
                        if (word[j] == char.Parse(values[k, 0]))
                        {
                            added = values[k, 1];
                            if (added[0] == last)
                            {
                                converted += " ";
                            }
                            converted += added;
                            last = added[added.Length - 1];
                            break;
                        }
                    }
                }
                Console.WriteLine("Case #{0}: {1}", i, converted);
            }
        }
    }
}
