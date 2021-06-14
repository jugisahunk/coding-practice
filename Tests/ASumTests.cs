using CodingPractice;
using Xunit;

namespace CodingPracticeTests
{
    public class ASumTests
    {


        [Theory]
        [InlineData(1,1)]
        [InlineData(9, 2)]
        [InlineData(24723578342962, -1)]
        [InlineData(135440716410000, 4824)]
        [InlineData(40539911473216, 3568)]
        public void Given_volume_1_Return_1_cube(long volume, long cubes)
        {
            Assert.Equal(cubes, ASum.findNb(volume));
        }
    }
}
