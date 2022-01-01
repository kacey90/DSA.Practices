using System;
using System.Collections.Generic;

namespace ToptalTests.Practice1
{
    internal class CheckPalindromeTask
    {
        internal static void CheckPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Not Palindrome");
                return;
            }
            
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);
            }

            string reversed = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                reversed += stack.Pop();
            }

            if (reversed == str)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}
