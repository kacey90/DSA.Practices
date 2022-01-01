using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ToptalTests.Arrays;
using ToptalTests.General;
using ToptalTests.LeetCodeTests;
using ToptalTests.Practice1;

namespace ToptalTests
{
    public class Person
    {
        public int Id;
    }
    enum WorkingDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
    class Shape
    {
        protected int Sides { get; set; }
    }

    class Square : Shape
    {
        public int GetSides() => Sides;
    }
    class Processor<T>
    {
        public int Add(int value)
        {
            return value;
        }

        public T BaseValue { get; set; }
    }
    class DataProcessor<U> : Processor<int>
    {

    }

    enum Subscription
    {
        FREE, PREMIUM
    }
    class Program
    {
        static void Main(string[] args)
        {

            //object datetime = "11/25/2020 12:00:00 AM";
            Console.WriteLine(Subscription.FREE.ToString());

            //if (new PalindromeNumbers().IsNumberPalindrome(34543))
            //    Console.WriteLine("yes");
            //else
            //    Console.WriteLine("no");
            //var rotatedArray = new RotationOfArray().RotateArray(new[] { 1, 2, 3, 4, 5 }, 2);
            //for (int i = 0; i < rotatedArray.Length; i++)
            //{
            //    Console.Write(rotatedArray[i]);
            //}
            //var result = new MedianOfTwoSortedArrays().FindMedianSortedArrays(new int[] {}, new[] { 1 });
            //Console.WriteLine(result);
            //FindAllSubstringTask.FindAllSubstring("abcd");
            //Console.Write(StringChallenge("21aa3a ggg4g4g6ggg"));
            //ArrayChallenge(new int[] { 12, 2, 6, 7, 11 });
            //Console.WriteLine(CompressString("aaabbcad"));
            //var ans = solution(new[] { "sander", "amy", "ann", "michael" }, new[] { "123456789", "234567890", "789123456", "123123123" }, "1");
            //var ans2 = solution2("0 - 22 1985--324");
            //Console.WriteLine(ans2);
        }

        static void test()
        {
            Console.Write("test()");
        }

        private static bool DoSomething()
        {
            Console.Write("working");
            return false;
        }

        private static void Display(int i = 0)
        {
            Console.WriteLine(i);
        }

        public static string StringChallenge(string str)
        {

            // code goes here
            var words = str.Split(' ');
            string result = "";
            bool isConsecutive = false;
            foreach (var word in words)
            {
                var counter = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsNumber(word[i]))
                    {
                        if (word.Count(x => x == word[i]) > 1)
                            return "false";

                        if (i == 0)
                        {
                            //result = "true";
                            counter++;
                        }
                        else if (char.IsNumber(word[i - 1]))
                        {
                            isConsecutive = true;
                            counter++;
                        }
                        else if (isConsecutive && counter == 3)
                        {
                            return "false";
                        }
                        else
                        {
                            //result = "true";
                            counter++;
                        }
                        //result = "true";
                        if (counter == 3)
                            result = "true";
                        else
                            result = "false";
                    }
                    
                    
                }
            }
            return result;
        }

        public static void ArrayChallenge(int[] arr)
        {
            var numRange = Enumerable.Range(1, arr[0]).ToArray();
            //var result = 0;
            for (int i = 0; i < numRange.Length; i++)
            {
                Console.WriteLine(numRange[i]);
            }
        }

        public static string CompressString(string input)
        {
            var charCounter = 0;
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (charCounter == 0 && result == string.Empty)
                {
                    charCounter++;
                    result += input[i];
                }
                else
                {
                    if (input[i] == input[i - 1])
                    {
                        charCounter++;
                    }
                    else
                    {
                        result += charCounter.ToString();
                        charCounter = 1;
                        result += input[i];
                    }
                }
            }

            return result + charCounter;
        }

        static string solution(string[] A, string[] B, string P)
        {
            var B_indices = new List<int>();

            for (int i = 0; i < B.Length; i++)
            {
                int index = B[i].IndexOf(P);
                if (index != -1)
                    B_indices.Add(i);
            }

            var A_names = new List<string>();
            foreach (var index in B_indices)
            {
                A_names.Add(A[index]);
            }

            A_names.Sort();

            var contactName = A_names.FirstOrDefault();
            if (contactName == null)
                return "NO CONTACT";

            return contactName;
        }

        static string solution2(string S)
        {
            // remove all spaces in S
            S = S.Replace(" ", string.Empty);

            // remove all dashes in S
            S = S.Replace("-", string.Empty);
            int blockLength = 3;
            var digits = new List<string>();

            for (int i = 0; i < S.Length; i += blockLength)
            {
                var digit = S.Substring(i, Math.Min(blockLength, S.Length - i));
                if (digit.Length < blockLength)
                    digit = S.Substring(i, Math.Min(blockLength - 1, S.Length - i));
                digits.Add(digit);
            }

            return string.Join("-", digits);
        }
    }
}
