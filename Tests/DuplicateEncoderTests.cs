using CodingPractice;
using Xunit;

namespace CodingPracticeTests
{
    public class DuplicateEncoderTests
    {

        [Theory]
        [InlineData("(((", "din")]
        [InlineData("()()()", "recede")]
        [InlineData(")())())", "Success")]
        [InlineData("))(()(", "((_*()")]
        public void Given_string_Return_duplicate_chars_encoded(string encodedString, string beginningString)
        {
            Assert.Equal(encodedString, Kata.DuplicateEncode(beginningString));
        }

    }
}
