namespace ToptalTests.Arrays
{
    public class RotationOfArray
    {
        public int[] LeftRotateBy1(int[] arr)
        {
            int x = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = x;
            return arr;
        }

        public int[] RightRotateBy1(int[] arr)
        {
            int x = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = x;
            return arr;
        }

        // popup and unshifting algorithm
        public int[] RotateArray(int[] arr, int position)
        {
            int k = 0;
            while (k < position)
            {
                int x = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = x;
                k++;
            }
            return arr;
        }

        /// <summary>
        /// Rotate Array using Reversal Algorithm
        /// 1. Take the value of position from the user.
        /// 2. Create a function named swapArray to swap the value with input parameters are array, starIndex, and lastIndex.
        /// 3. Call function swapArray with (arr, 0, (position-1))
        /// 4. Call function swapArray with (arr,position,(n-1))
        /// 5. Call function swapArray with (arr, 0, (n-1))
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        //public int[] RotateArrayByReversalAlgorithm(int[] arr, int position)
        //{
        //    while
        //}
    }
}
