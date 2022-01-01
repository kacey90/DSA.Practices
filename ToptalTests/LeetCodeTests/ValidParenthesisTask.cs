using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptalTests.LeetCodeTests
{
    /// <summary>
    /// 20. Valid Parentheses
    /// Given a string containing just the characters '( ) { } [ ]'. Determine if the input string is valid
    /// An input string is valid if:
    ///     1) Open brackets must be closed by the same type of brackets.
    ///     2) Open brackets must be closed in the correct order.
    /// IE) Input  :  "()[]{}"
    ///     Output :  true
    /// </summary>
    public class ValidParenthesisTask
    {
        public bool IsValid(string input)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> dictionary = new Dictionary<char, char> {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };

            if (string.IsNullOrEmpty(input))
                return false;

            for (int i = 0; i < input.Length; i++)
            {
                if (dictionary.ContainsKey(input[i]))
                    stack.Push(input[i]);
                if (dictionary.ContainsValue(input[i]) && stack.Count >= 1)
                {
                    var topchar = stack.Peek();
                    if (topchar == dictionary.FirstOrDefault(x => x.Value == input[i]).Key)
                        stack.Pop();
                    else
                        return false;
                }
                else if (stack.Count == 0)
                    return false;
            }
            return stack.Count == 0;
        }
    }
}
