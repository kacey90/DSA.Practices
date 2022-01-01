using System.Collections.Generic;

namespace ToptalTests.LeetCodeTests
{
    public class FirstUniqueCharacterInString
    {
        public int FirstUniqChar(string s)
        {
            List<char> copies = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                var noCopies = true;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j]) 
                    {
                        copies.Add(s[j]);
                        noCopies = false;
                        break;
                    }
                }

                if (noCopies && !copies.Contains(s[i]))
                    return i;
            }

            return -1;
        }
    }
}
