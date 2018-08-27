using Xunit;

namespace LeetCodes.Test
{
    public class A392IsSubsequenceTest : TestTemplate
    {
        [Fact]
        public void Test()
        {
            foreach (var solution in Solutions)
            {
                var result = (bool) Invoke(solution, new object[]
                {
                    "abc",
                    "ahbgdc"
                });
            }
        }
    }
}