using Xunit;
using CodingPractice;

namespace Tests
{
    public class VowelCountTests
    {
        [Theory]
        [InlineData(5, "Abracadabra")]
        [InlineData(2, "yEarly")]
        [InlineData(0, "123")]
        [InlineData(10, "aeiouAEIOU")]
        public void Given_Abracadabra_Return_Fivecount(int expectedVowelCount, string word)
        {
            //Arrange (above InlineData)

            //Act
            int actualVowelCount = Kata.GetVowelCount(word);

            //Assert
            Assert.True(expectedVowelCount == actualVowelCount, $"Expected {expectedVowelCount} vowel count but received {actualVowelCount}");
        }
    }
}
