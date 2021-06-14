using CodingPractice;
using Xunit;

namespace CodingPracticeTests
{
    public class CountingSheep
    {

        [Fact]
        public void Given_sheep_array_Return_count_of_present()
        {
            var sheeps = new bool[] { true, false, true };
            Assert.Equal(2, Kata.CountSheeps(sheeps));
        }

    }
}
