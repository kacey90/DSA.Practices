using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptalTests.LeetCodeTests
{
    /// <summary>
    /// 6. Remove Duplicates from Sorted Array
    /// Given a sorted array 'nums', remove the duplicates in-place such that each element appear only once and return the new length.
    /// Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
    /// IE) Input  :  nums = [1,1,2]
    ///     Output :  length = 2, with the first two elements of nums being 1 and 2
    /// </summary>
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 0)
                return 0;

            int j = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                    nums[j++] = nums[i];
            }
            nums[j++] = nums[nums.Length - 1];

            return j;
        }
    }
}
