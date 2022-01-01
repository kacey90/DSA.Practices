using System;

namespace ToptalTests.LeetCodeTests
{
    public class ReverseIntegerTask
    {
        public int ReverseInteger(int num)
        {
            string reversedIntegerString = string.Empty;
            var numString = num.ToString();

            if (num < 0)
            {
                reversedIntegerString += "-";
                numString = Math.Abs(num).ToString();
            }

            for (int i = numString.Length - 1; i >= 0; i--)
            {
                reversedIntegerString += numString[i].ToString();
            }

            var reversedInteger = Convert.ToInt64(reversedIntegerString);
            if (reversedInteger > int.MaxValue)
                return 0;
            else
                return (int)reversedInteger;
        }
    }
}
