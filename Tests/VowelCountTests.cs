using Xunit;
using CodingPractice;

namespace Tests
{
    public class VowelCountTests
    {

        [Fact]
        public void Given_Abracadabra_Return_FiveCount()
        {
            Assert.Equal(5,Kata.GetVowelCount("Abracadabra"));
        }

    }
}
