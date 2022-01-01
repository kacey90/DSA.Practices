using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptalTests.LeetCodeTests
{
    /// <summary>
    /// Given an integer x, return true if x is palindrome integer.
    ///An integer is a palindrome when it reads the same backward as forward.
    ///For example, 121 is palindrome while 123 is not.
    /// </summary>
    public class PalindromeNumberTask
    {
        public bool IsPalindrome(int num)
        {
            if (num < 0)
                return false;

            string stringNum = num.ToString();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < stringNum.Length; i++)
            {
                stack.Push(stringNum[i]);
            }
            string result = "";
            for (int i = 0; i < stringNum.Length; i++)
            {
                result += stack.Pop();
            }

            return result == stringNum;
        }
    }
}
