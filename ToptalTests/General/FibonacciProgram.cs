using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptalTests.General
{
    public class FibonacciProgram
    {
        public void FibonacciSeries(int firstNumber, int secondNumber, int counter, int number)
        {
            Console.Write(firstNumber + " ");
            if (counter < number)
            {
                FibonacciSeries(secondNumber, firstNumber + secondNumber, counter + 1, number);
            }
        }
    }
}
