using Xunit;
using CodingPractice;

namespace Tests
{
    public class VowelCountTests
    {
        [Theory]
        [InlineData(5, "abracadabra")]
        [InlineData(2, "yearly")]
        [InlineData(0, "123")]
        [InlineData(5, "aeiou")]
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
