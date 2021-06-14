using Xunit;
using CodingPractice;

namespace CodingPracticeTests
{
    public class VowelCountTests
    {

        [Fact]
        public void Given_word_Return_vowel_count()
        {
            Assert.Equal(3, Kata.GetVowelCount("Hello World!"));
        }


        [Fact]
        public void Given_long_word_Return_vowel_count()
        {
            Assert.Equal(5, Kata.GetVowelCount("abracadabra"));
        }


        [Fact]
        public void Given_no_vowels_Return_count_zero()
        {
            Assert.Equal(0, Kata.GetVowelCount("qwrtyplkjhgsdf"));
        }

    }
}
