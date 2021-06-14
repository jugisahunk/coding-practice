using Xunit;
using CodingPractice;

namespace CodingPracticeTests
{
    public class ExpressionsMatterTests
    {

        [Theory]
        [InlineData(1,2,3)]
        public void Given_numbers_Return_max_value(int a, int b, int c)
        {
            Assert.Equal(9, Kata.ExpressionsMatter(a, b, c));
        }

        [Theory]
        [InlineData(6, 2, 1, 2)]
        [InlineData(3, 1, 1, 1)]
        [InlineData(4, 2, 1, 1)]
        [InlineData(9, 1, 2, 3)]
        [InlineData(5, 1, 3, 1)]
        [InlineData(8, 2, 2, 2)]
        public void CheckSmallValues(int expected, params int[] a)
        {
            Assert.Equal(Kata.ExpressionsMatter(a[0], a[1], a[2]), expected);
        }

        [Theory]
        [InlineData(020, 5, 1, 3)]
        [InlineData(105, 3, 5, 7)]
        [InlineData(035, 5, 6, 1)]
        [InlineData(008, 1, 6, 1)]
        [InlineData(014, 2, 6, 1)]
        [InlineData(048, 6, 7, 1)]
        public void CheckIntermediateValues(int expected, params int[] a)
        {
            Assert.Equal(Kata.ExpressionsMatter(a[0], a[1], a[2]), expected);
        }

        [Theory]
        [InlineData(060, 02, 10, 03)]
        [InlineData(027, 01, 08, 03)]
        [InlineData(126, 09, 07, 02)]
        [InlineData(020, 01, 01, 10)]
        [InlineData(018, 09, 01, 01)]
        [InlineData(300, 10, 05, 06)]
        [InlineData(012, 01, 10, 01)]
        public void CheckMixedValues(int expected, params int[] a)
        {
            Assert.Equal(Kata.ExpressionsMatter(a[0], a[1], a[2]), expected);
        }
    }
}
