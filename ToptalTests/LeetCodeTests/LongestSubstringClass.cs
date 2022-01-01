using System.Collections.Generic;

namespace ToptalTests.LeetCodeTests
{
    public class LongestSubstringClass
    {
        /// <summary>
        /// Longest Substring Without Repeating Characters
        /// Given a string, find the length of the longest substring without repeating characters
        /// IE) Input  :  "abccbb"
        ///     Output :  3
        /// Explanation:  "abc" has a length of 3
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string inputString)
        {

            int i = 0;
            int pointer = 0;
            int maxSubstring = 0;
            HashSet<string> hashSet = new HashSet<string>();

            while (i < inputString.Length && pointer < inputString.Length)
            {
                if (!hashSet.Contains(inputString[i].ToString()))
                {
                    hashSet.Add(inputString[i++].ToString());
                }
                else
                {
                    if (hashSet.Count > maxSubstring)
                    {
                        maxSubstring = hashSet.Count;
                    }
                    pointer++;
                    i = pointer;
                    hashSet.Clear();
                }
            }
            if (hashSet.Count > maxSubstring)
            {
                maxSubstring = hashSet.Count;
            }
            return maxSubstring;
        }

        public int LengthOfLongestSubstring2(string s)
        {
            HashSet<char> hashset = new HashSet<char>();
            int maxSubstring = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!hashset.Contains(s[i]))
                {
                    hashset.Add(s[i]);
                }
                else
                {
                    if (hashset.Count > maxSubstring)
                    {
                        maxSubstring = hashset.Count;
                    }
                    i--;
                    hashset.Clear();
                }
            }
            if (hashset.Count > maxSubstring)
            {
                return hashset.Count;
            }
            else
            {
                return maxSubstring;
            }
        }
    }
}
