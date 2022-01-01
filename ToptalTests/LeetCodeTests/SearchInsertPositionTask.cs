using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptalTests.LeetCodeTests
{
    /// <summary>
    /// 35. Search Insert Position
    /// Given a sorted array and a target value, return the index if the target is found. If not, rerun the index where it would be if it were inserted in order.
    /// IE) Input  :  [1, 3, 5, 6]    Target = 5
    ///     Output :  2
    /// Explanation:  Target '5' is found in the array at the index position [2]
    /// </summary>
    public class SearchInsertPositionTask
    {
        public int SearchInsertPosition(int[] nums, int target)
        {
            if (target < nums[0])
                return 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                    continue;
                if (target > nums[i - 1] && target < nums[i])
                    return i;
            }

            return nums.Length;
        }
    }
}
