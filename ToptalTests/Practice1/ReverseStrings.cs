using System;

namespace ToptalTests.Practice1
{
    internal class ReverseStrings
    {
        internal static void ReverseString(string str)
        {
            var charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }

            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }

        internal static void ReverseString2(string str)
        {
            string reversedString = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedString += str[i].ToString();
            }
            Console.WriteLine(reversedString);
        }
    }
}
