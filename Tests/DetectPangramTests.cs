using CodingPractice;
using Xunit;

namespace CodingPracticeTests
{
    public class DetectPangramTests
    {

        [Fact]
        public void Given_pangram_Return_true()
        {
            Assert.True(Kata.IsPangram("The quick brown fox jumps over the lazy dog."));
        }

        [Fact]
        public void Given_null_Return_false()
        {
            Assert.False(Kata.IsPangram(null));
        }

        [Fact]
        public void Given_empty_string_Return_false()
        {
            Assert.False(Kata.IsPangram(string.Empty));
        }


        [Fact]
        public void Given_asdf_Return_false()
        {
            Assert.False(Kata.IsPangram("asdf"));
        }

    }
}
