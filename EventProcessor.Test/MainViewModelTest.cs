using Xunit;

namespace EventProcessorTemplate.Test
{
    public class MainViewModelTest
    {
        [Theory]
        [InlineData(10,2,8)]
        [InlineData(5, 2, 3)]
        [InlineData(2, 15, -13)]
        public void Constructor_Pass_Test(
            int expectedResult,
            int val1,
            int val2)
        {
        }

    }
}
