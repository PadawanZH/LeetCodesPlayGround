using Xunit;

namespace LeetCodes.Test
{
    public class A013RomanToIntegerTest 
    {
        [Fact]
        public void Test()
        {
            A013RomanToInteger Test = new A013RomanToInteger();
            Assert.Equal(3, Test.RomanToInt("III"));
        }
    }
}