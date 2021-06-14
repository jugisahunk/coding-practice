using CodingPractice;
using Xunit;

namespace CodingPracticeTests
{
    public class EvenOrOdd
    {

        [Fact]
        public void Given_2_Return_Even()
        {
            Assert.Equal("Even", Kata.EvenOrOdd(2));
        }


        [Fact]
        public void Given_1_Return_Odd()
        {
            Assert.Equal("Odd", Kata.EvenOrOdd(1));
        }


        [Fact]
        public void Given_Zero_Return_expectation()
        {
            Assert.Equal("Even", Kata.EvenOrOdd(0));
        }


        [Fact]
        public void Given_7_Return_Odd()
        {
            Assert.Equal("Odd", Kata.EvenOrOdd(7));
        }


        [Fact]
        public void Given_Neg_One_Return_Odd()
        {
            Assert.Equal("Odd", Kata.EvenOrOdd(-1));
        }


        [Fact]
        public void Given_5_Return_Odd()
        {
            Assert.Equal("Odd", Kata.EvenOrOdd(5));
        }

    }
}
