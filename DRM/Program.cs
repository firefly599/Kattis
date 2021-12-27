using System;

namespace DRM
{
    class Program
    {
        static int rotateValue(string input)
        {
            // Gets the rotation values for each half
            int rotation = 0;
            for (int i = 0; i < input.Length; i++)
            {
                rotation += (int)input[i] - 65;
            }
            return rotation;
        }

        static string shiftString(string input, int rotationValue)
        {
            // Shifts each character in the string by the rotation value
            int temp;
            string shifted = "";
            for (int i = 0; i < input.Length; i++)
            {
                temp = input[i] + rotationValue;
                if (temp > 90)
                {
                    temp = 65 + temp % 91;
                }
                shifted += (char)temp;
            }
            return shifted;
        }

        static string merge(string left, string right)
        {
            // Merges the strings by offsetting the left string by the index value of the right string
            string shifted = "";
            int shift;
            int temp;
            for (int i = 0; i < left.Length; i++)
            {
                shift = (int)right[i] - 65;
                temp = (int)left[i] + shift;
                if (temp > 90)
                {
                    temp = 65 + temp % 91;
                }
                shifted += (char)temp;
            }
            return shifted;
        }

        static void Main(string[] args)
        {
            // DRM Messages
            string input = Console.ReadLine();
            int halfSize = input.Length / 2;
            string left = input.Substring(0, halfSize);
            string right = input.Substring(halfSize, halfSize);

            int leftRotation = rotateValue(left) % 26;
            int rightRotation = rotateValue(right) % 26;

            left = shiftString(left, leftRotation);
            right = shiftString(right, rightRotation);

            Console.WriteLine(merge(left, right));
        }
    }
}
