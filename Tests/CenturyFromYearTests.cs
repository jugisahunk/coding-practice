using Xunit;
using CodingPractice;

namespace CodingPracticeTests
{
    public class CenturyFromYearTests
    {

        [Theory]
        [InlineData(18, 1705)]
        [InlineData(19, 1900)]
        public void Given_years_Return_century(int expectedCentury, int year)
        {
            Assert.Equal(expectedCentury, Kata.CenturyFromYear(year));
        }

    }
}
