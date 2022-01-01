namespace ToptalTests.LeetCodeTests
{
    //Given an integer array nums, find the contiguous subarray (containing at least one number) which has the
    //largest sum and return its sum.

    //A subarray is a contiguous part of an array.
    public class MaximumSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int maxSum = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (nums[i] > sum)
                {
                    sum = nums[i];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            return maxSum;
        }
    }
}
