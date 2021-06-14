using CodingPractice;
using Xunit;

namespace CodingPracticeTests
{
    public class WhatBetweenTests
    {

        [Theory]
        [InlineData(0,3, new int[] { 0, 1, 2, 3 })]
        [InlineData(-2, 2, new int[] { -2, -1, 0, 1, 2 })]
        [InlineData(-10, 10, new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void Given_Two_Integers_Return_Integers_Between(int start, int end, int[] betweenNumbers)
        {
            Assert.Equal(betweenNumbers, Kata.Between(start, end));
        }

    }
}
