using CodingPractice;
using Xunit;

namespace CodingPracticeTests
{
    public class WhatBetweenTests
    {

        //[Theory]
        //[InlineData(0,3, new int[] { 0, 1, 2, 3 })]
        //[InlineData(-2, 2, new int[] { -2, -1, 0, 1, 2 })]
        //[InlineData(-10, 10, new int[] { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        //[InlineData(2,-2, new int[] {-2, -1, 0, 1, 2 })]
        //public void Given_Two_Integers_Return_Integers_Between(int start, int end, int[] betweenNumbers)
        //{
        //    Assert.Equal(betweenNumbers, Kata.Between(start, end));
        //}

        public static void test()
        {
            Assert.True(Kata.is_valid_IP("0.0.0.0"));
            Assert.True(Kata.is_valid_IP("12.255.56.1"));
            Assert.True(Kata.is_valid_IP("137.255.156.100"));

            Assert.False(Kata.is_valid_IP(""));
            Assert.False(Kata.is_valid_IP("abc.def.ghi.jkl"));
            Assert.False(Kata.is_valid_IP("123.456.789.0"));
            Assert.False(Kata.is_valid_IP("12.34.56"));
            Assert.False(Kata.is_valid_IP("12.34.56.00"));
            Assert.False(Kata.is_valid_IP("12.34.56.7.8"));
            Assert.False(Kata.is_valid_IP("12.34.256.78"));
            Assert.False(Kata.is_valid_IP("1234.34.56"));
            Assert.False(Kata.is_valid_IP("pr12.34.56.78"));
            Assert.False(Kata.is_valid_IP("12.34.56.78sf"));
            Assert.False(Kata.is_valid_IP("12.34.56 .1"));
            Assert.False(Kata.is_valid_IP("12.34.56.-1"));
            Assert.False(Kata.is_valid_IP("123.045.067.089"));

        }

    }
}