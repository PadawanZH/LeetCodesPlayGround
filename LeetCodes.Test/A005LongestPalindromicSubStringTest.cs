using Xunit;

namespace LeetCodes.Test
{
    public class A005LongestPalindromicSubStringTest : TestTemplate
    {
        [Fact]
        public void Test()
        {
            string a = "abcdefghhgfedcsd";

            foreach (var solution in Solutions)
            {
                var result = (string) Invoke(solution, new object[] {a});
                Assert.Equal("cdefghhgfedc", result);
            }
        }
    }
}