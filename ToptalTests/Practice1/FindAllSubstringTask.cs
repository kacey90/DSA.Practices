
using System;
using System.Text;

namespace ToptalTests.Practice1
{
    public class FindAllSubstringTask
    {
        //input: abcd , output : a ab abc abcd b bc bcd c cd d
        internal static void FindAllSubstring(string str)
        {
            if (string.IsNullOrEmpty(str))
                return;

            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; j++)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }
    }
}
