using Xunit;
using CodingPractice;

namespace CodingPracticeTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Given_1_Return_1()
        {
            FizzBuzz target = new FizzBuzz();
            Assert.Equal("1", target.Translate(1));
        }

        
        [Fact]
        public void Given_2_Return_2()
        {
            FizzBuzz target = new FizzBuzz();
            Assert.Equal("2", target.Translate(2));
        }

/*
        [Fact]
        public void Given_3_Return_Fizz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.Equal("Fizz", fizzBuzz.Translate(3));
        }


        [Fact]
        public void Given_5_Return_Buzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.Equal("Buzz", fizzBuzz.Translate(5));
        }


        [Fact]
        public void Given_15_Return_FizzBuzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.Equal("FizzBuzz", fizzBuzz.Translate(15));
        }
        */
    }
}
