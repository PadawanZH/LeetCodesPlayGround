using Xunit;

namespace LeetCodes.Test
{
    public class A008AtoiTest : TestTemplate
    {
        [Fact]
        public void Test()
        {
            //"+", "3.123.23 = 3", "."
            string s1 = "-3.1415938";
            foreach (var solution in Solutions)
            {
                var resultx = (int) Invoke(solution, new object[] {s1});
                Assert.Equal(-3, resultx);
            }
        }
    }
}