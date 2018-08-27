using Xunit;

namespace LeetCodes.Test
{
    public class A062UniquePathsTest : TestTemplate
    {
        [Fact]
        public void Test()
        {
            foreach (var solution in Solutions)
            {
                var result = (bool) Invoke(solution, new object[]
                {
                    36, 7
                });
            }
        }
    }
}