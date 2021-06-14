
using System;
using System.Collections.Generic;

namespace CodingPractice
{
    public class DivisibleNb
    {
        public static bool isDivisible(int dividend, int divisor1, int divisor2)
        {
            return dividend % divisor1 + dividend % divisor2 == 0;
        }
    }
}
