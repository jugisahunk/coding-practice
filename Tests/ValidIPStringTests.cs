using Xunit;
using CodingPractice;

namespace CodingPracticeTests
{
    public class ValidIPStringTests
    {

        [Theory]
        [InlineData(true, "0.0.0.0")]
        [InlineData(true, "12.255.56.1")]
        [InlineData(true, "137.255.156.100")]

        [InlineData(false, "")]
        [InlineData(false, "abc.def.ghi.jkl")]
        [InlineData(false, "123.456.789.0")]
        [InlineData(false, "12.34.56")]
        [InlineData(false, "12.34.56.00")]
        [InlineData(false, "12.34.56.7.8")]
        [InlineData(false, "12.34.256.78")]
        [InlineData(false, "1234.34.56")]
        [InlineData(false, "pr12.34.56.78")]
        [InlineData(false, "12.34.56.78sf")]
        [InlineData(false, "12.34.56 .1")]
        [InlineData(false, "12.34.56.-1")]
        [InlineData(false, "123.045.067.089")]        
        public static void Given_given_ip_addresses_Return_if_they_are_valid(bool isValidIP, string pattern)
        {
            Assert.Equal(isValidIP, Kata.is_valid_IP(pattern));
        }

    }
}
