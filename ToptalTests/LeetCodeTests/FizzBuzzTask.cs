using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptalTests.LeetCodeTests
{
    /// <summary>
    /// 412. FizzBuzz
    /// Write a program that outputs the string of numbers from 1 to n.
    ///  for multiples of three it should output "Fizz"
    ///  for multiples of five it should output  "Buzz"
    ///  for multiples of both it should output  "FizzBuzz"
    /// IE) Input:  n = 10
    ///     Output: ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"]
    /// </summary>
    public class FizzBuzzTask
    {
        public IList<string> FizzBuzz(int n)
        {
            var numbersList = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                    numbersList.Add(i.ToString());
                else
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        numbersList.Add("FizzBuzz");
                    else if (i % 5 == 0)
                        numbersList.Add("Buzz");
                    else if (i % 3 == 0)
                        numbersList.Add("Fizz");
                    else
                        numbersList.Add(i.ToString());
                }
            }

            return numbersList;
        }
    }
}
