using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using ToptalTests.Hackerrank;
using ToptalTests.LeetCodeTests;

namespace ToptalTasksTester
{
    [TestFixture]
    public class ToptalTasksTests
    {
        [Test]
        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        [TestCase(new[] { 0, 4, 3, 0 }, 0, new[] { 0, 3 })]
        [TestCase(new[] { -3, 4, 3, 90 }, 0, new[] { 0, 2 })]
        public void TwoSums_IsCorrect(int[] nums, int target, int[] expected)
        {
            var result = new TwoSums().TwoSum(nums, target);

            foreach (var value in expected)
            {
                Assert.Contains(value, result);
            }
        }

        [Test]
        [TestCase("abcabcbb", 3)]
        [TestCase("pwwkew", 3)]
        [TestCase("aab", 2)]
        [TestCase("abba", 2)]
        [TestCase("cdd", 2)]
        [TestCase("dvdf", 3)]
        [TestCase("", 0)]
        [TestCase(" ", 1)]
        public void LengthOfLongestSubstring_IsCorrect(string inputString, int expected)
        {
            var result = new LongestSubstringClass().LengthOfLongestSubstring(inputString);
            Assert.IsTrue(result == expected);
        }

        [Test]
        [TestCase(123, 321)]
        [TestCase(-123, -321)]
        [TestCase(120, 21)]
        [TestCase(1534236469, 0)]
        public void ReverseInteger_IsCorrect(int num, int expected)
        {
            var result = new ReverseIntegerTask().ReverseInteger(num);
            Assert.IsTrue(result == expected);
        }

        [Test]
        [TestCase(121, true)]
        [TestCase(-121, false)]
        [TestCase(10, false)]
        [TestCase(0, true)]
        [TestCase(1000021, false)]
        public void IsPalindorome_IsCorrect(int num, bool expected)
        {
            var result = new PalindromeNumberTask().IsPalindrome(num);
            Assert.That(result == expected);
        }

        [Test]
        [TestCase("()", true)]
        [TestCase("()[]{}", true)]
        [TestCase("(]", false)]
        [TestCase("([)]", false)]
        [TestCase("{[]}", true)]
        [TestCase("]", false)]
        [TestCase("", true)]
        [TestCase("([]", false)]
        public void ValidParenthesis_IsValid_IsCorrect(string input, bool expected)
        {
            var result = new ValidParenthesisTask().IsValid(input);
            Assert.IsTrue(result == expected);
        }

        [Test]
        [TestCase(new[] {1, 1, 2}, 2)]
        [TestCase(new[] {2, 5, 5, 7, 8, 9, 11, 11, 13}, 7)]
        public void RemoveDuplicatesFromSortedArray_RemoveDuplicates_IsCorrect(int[] nums, int expected)
        {
            var result = new RemoveDuplicatesFromSortedArray().RemoveDuplicates(nums);
            Assert.IsTrue(result == expected);
        }

        [Test]
        [TestCase(new[] { 1, 3, 5, 6 }, 5, 2)]
        [TestCase(new[] { 1, 3, 5, 6 }, 6, 3 )]
        [TestCase(new[] { 1, 3, 5, 6 }, 4, 2)]
        [TestCase(new[] {1, 3, 5, 6 }, 2, 1)]
        public void SearchInsertPositionTask_SearchInsertPosition_IsCorrect(int[] nums, int target, int expected)
        {
            var result = new SearchInsertPositionTask().SearchInsertPosition(nums, target);
            Assert.IsTrue(result == expected);
        }

        [Test]
        [TestCase(3, new[] { "1", "2", "Fizz" })]
        [TestCase(5, new[] { "1", "2", "Fizz", "4", "Buzz" })]
        [TestCase(15, new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        public void FizzBuzzTask_FizzBuzz_IsCorrect(int n, string[] expected)
        {
            var result = new FizzBuzzTask().FizzBuzz(n).ToArray();
            Assert.AreEqual(expected, result);

        }

        [Test]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(10, 55)]
        public void FibonacciTask_Fib_IsCorrect(int n, int expected)
        {
            var result = new FibonacciTask().Fib(n);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("leetcode", 0)]
        [TestCase("loveleetcode", 2)]
        [TestCase("aabb", -1)]
        [TestCase("afteracademy", 1)]
        [TestCase("mindorks", 0)]
        [TestCase("abacdcd", 1)]
        public void FirstUniqueCharacterInString_FirstUniqChar_IsCorrect(string s, int expected)
        {
            var result = new FirstUniqueCharacterInString().FirstUniqChar(s);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(new[] { 1, 1, 0, 1, 1, 1 }, 3)]
        [TestCase(new[] { 1, 0, 1, 1, 0, 1 }, 2)]
        [TestCase(new[] { 1, 0, 0, 1, 0, 1, 0, 0, 1}, 1)]
        public void MaxConsecutiveOnesTask_FindMaxConsecutiveOnes_IsCorrect(int[] nums, int expected)
        {
            var result = new MaxConsecutiveOnesTask().FindMaxConsecutiveOnes(nums);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(new[] { 17, 28, 30 }, new[] { 99, 16, 8 }, new[]  { 2, 1 })]
        [TestCase(new[] { 5, 6, 7 }, new[] { 3, 6, 10 }, new[] { 1, 1 })]
        [TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, new[] { 1, 1 })]
        public void Hackerrank_CompareTriplets_IsCorrect(int[] a, int[] b, int[] expected)
        {
            var result = new CompareTripletsTask().CompareTriplets(a.ToList(), b.ToList());
            Assert.AreEqual(expected, result.ToArray());
        }

        [Test]
        [TestCase(new[] { 73, 67, 38, 33}, new[] { 75, 67, 40, 33})]
        public void Hackerrank_GradingStudents_IsCorrect(int[] grades, int[] expected)
        {
            var result = new GradingStudentsTask().GradingStudents(grades.ToList());
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(new int[] {}, new[] {2, 3}, 2.5)]
        public void LeetCodeTests_FindMedianSortedArrays_IsCorrect(int[] nums1, int[] nums2, double expected)
        {
            var result = new MedianOfTwoSortedArrays().FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(new int[] {1, 2, 3, 4, 5}, 4)]
        public void LeetCodeTests_BestTimeBuySellStock_MaxProfit_IsCorrect(int[] prices, int expected)
        {
            var result = new BestTimeBuySellStock().MaxProfit2(prices);
            Assert.AreEqual(expected, result);
        }
    }
}
