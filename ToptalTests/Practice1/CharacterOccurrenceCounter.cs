using System;
using System.Collections.Generic;

namespace ToptalTests.Practice1
{
    internal class CharacterOccurrenceCounter
    {
        internal static void Countcharacter(string str)
        {
            IDictionary<char, int> dictCounter = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (c != ' ')
                {
                    if (dictCounter.ContainsKey(c))
                        dictCounter[c]++;
                    else
                        dictCounter.Add(c, 1);
                }
            }

            foreach (var item in dictCounter)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
