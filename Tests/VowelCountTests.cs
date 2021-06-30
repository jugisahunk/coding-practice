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
        public void Given_Abracadabra_Return_Fivecount(int vowelCount, string word)
        {
            int actualVowelCount = Kata.GetVowelCount(word);
            Assert.True(vowelCount == actualVowelCount, string.Format("Expected {0} vowel count but received {1}", vowelCount, actualVowelCount));
        }
    }
}
