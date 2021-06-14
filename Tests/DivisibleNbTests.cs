using Xunit;
using CodingPractice;
using System.Collections.Generic;
using System;

namespace CodingPracticeTests
{
    public class DivisibleNbTests
    {

        [Theory]
        [InlineData(12,4,3)]
        public void Given_Quotient_Is_Divisible_Return_True(int dividend, int divisor1, int divisor2)
        {
            Assert.True(DivisibleNb.isDivisible(dividend, divisor1, divisor2));
        }


        [Theory]
        [InlineData(3,3,4)]
        [InlineData(8,3,4)]
        public void Given_Quotient_Is_Not_Divisible_Return_False(int dividend, int divisor1, int divisor2)
        {
            Assert.False(DivisibleNb.isDivisible(dividend, divisor1, divisor2));
        }

    }
}
