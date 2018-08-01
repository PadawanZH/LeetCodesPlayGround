using Xunit;

namespace LeetCodes.Test
{
    public class A006ZigZagConversionTest : TestTemplate
    {
        [Fact]
        public void Test()
        {
            string a = "PANT";

            foreach (var solution in Solutions)
            {
                var result = (string) Invoke(solution, new object[] {a, 2});
                Assert.Equal("PNAT", result);
            }
        }
    }
}