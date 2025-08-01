
using Xunit;

namespace HelloWorldFunction.Tests
{
    public class FunctionTests
    {
        [Fact]
        public void SampleTest()
        {
            int result = 5 + 3;
            Assert.Equal(8, result);
        }
    }
}
