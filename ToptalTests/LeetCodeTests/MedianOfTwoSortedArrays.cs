namespace ToptalTests.LeetCodeTests
{
    public class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int nums1Size = nums1 == null && nums1.Length == 0 ? 0 : nums1.Length;
            int nums2Size = nums2 == null && nums2.Length == 0 ? 0 : nums2.Length;
            int[] arrayResult = new int[nums1Size + nums2Size];
            int nums1Index = 0, nums2Index = 0, i = 0;
            while (nums1Index < nums1Size && nums2Index < nums2Size)
            {
                if (nums1[nums1Index] <= nums2[nums2Index])
                {
                    arrayResult[i++] = nums1[nums1Index++];
                }
                else
                {
                    arrayResult[i++] = nums2[nums2Index++];
                }
            }

            if (nums1Index < nums1Size)
            {
                for (int j = nums1Index; j < nums1Size; j++)
                {
                    arrayResult[i++] = nums1[j];
                }
            }
            else
            {
                for (int j = nums2Index; j < nums2Size; j++)
                {
                    arrayResult[i++] = nums2[j];
                }
            }
            double median;
            if (arrayResult.Length == 1)
                median = arrayResult[0];
            else
            {
                bool isOdd = arrayResult.Length % 2 != 0;
                median = isOdd ?
                    (double)arrayResult[(arrayResult.Length + 1) / 2 - 1] :
                ((double)arrayResult[arrayResult.Length / 2 - 1] + (double)arrayResult[arrayResult.Length / 2]) / 2;
                
            }
            return median;
        }
    }
}
