using System;

namespace Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bits
            string subString;
            string valueString;
            int tests = int.Parse(Console.ReadLine());
            int valueInt;
            int temp;
            int total;
            int localMax;
            for (int i = 0; i < tests; i++)
            {
                localMax = 0;
                valueString = Console.ReadLine();
                valueInt = int.Parse(valueString);
                for (int j = 0; j < valueString.Length; j++)
                {
                    total = 0;
                    temp = valueInt;
                    if (j > 0)
                    {
                        temp = valueInt / ((int)Math.Pow(10, j));
                    }
                    subString = Convert.ToString(temp, 2);
                    foreach (char digit in subString)
                    {
                        if (digit == '1')
                        {
                            total++;
                        }
                    }

                    if (total > localMax)
                    {
                        localMax = total;
                    }
                }
                
                Console.WriteLine(localMax);
            }
        }
    }
}
