using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToptalTests.LeetCodeTests
{
    public class FibonacciTask
    {
        public int Fib(int n)
        {
            if (n < 2)
                return n;

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
