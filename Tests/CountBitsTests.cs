using CodingPractice;
using Xunit;

namespace CodingPracticeTests
{
    public class CountBitsTests
    {

        [Theory]
        [InlineData(0, 0)]
        [InlineData(4, 1)]
        [InlineData(7, 3)]
        [InlineData(9, 2)]
        [InlineData(10, 2)]
        public void Given_int_Return_sum_of_bits(int number, int countOfBits)
        {
            Assert.Equal(countOfBits, Kata.CountBits(number));
        }

    }
}
