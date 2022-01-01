using System;
using System.Text;

namespace ToptalTests.Practice1
{
    internal class ReverseWordsOrder
    {
        internal static void ReverseWordOrder(string str)
        {
            if (string.IsNullOrEmpty(str))
                return;

            var reversedOrderedString = string.Empty;
            var wordsArr = str.Split(' ');
            for (int i = wordsArr.Length - 1; i >= 0; i--)
            {
                reversedOrderedString += wordsArr[i];
                if (i != 0)
                    reversedOrderedString += " ";
            }

            Console.WriteLine(reversedOrderedString);
        }

        internal static void ReverseWords(string str)
        {
            if (string.IsNullOrEmpty(str))
                return;

            var output = new StringBuilder();
            var words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    output.Append(words[i][j]);
                }
                if (i != words.Length - 1)
                    output.Append(" ");
            }

            Console.WriteLine(output.ToString());
        }
    }
}
