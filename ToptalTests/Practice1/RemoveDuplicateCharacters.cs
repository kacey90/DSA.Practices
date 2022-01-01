using System;

namespace ToptalTests.Practice1
{
    internal class RemoveDuplicateCharacters
    {
        internal static void Removeduplicate(string str)
        {
            if (string.IsNullOrEmpty(str))
                return;

            var output = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (!output.Contains(str[i]))
                    output += str[i];
            }

            Console.WriteLine(output);
        }
    }
}
