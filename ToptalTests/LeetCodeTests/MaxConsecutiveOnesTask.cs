using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptalTests.LeetCodeTests
{
    public class MaxConsecutiveOnesTask
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var oneCounter = 0;
            var maxOneCounter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    oneCounter += 1;
                    if (maxOneCounter < oneCounter)
                        maxOneCounter = oneCounter;
                }
                else
                    oneCounter = 0;
            }

            return maxOneCounter;
        }
    }
}
