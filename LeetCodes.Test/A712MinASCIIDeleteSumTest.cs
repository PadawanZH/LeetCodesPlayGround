using Xunit;

namespace LeetCodes.Test
{
    public class A712MinASCIIDeleteSumTest : TestTemplate
    {
        [Fact]
        public void Test()
        {
            foreach (var solution in Solutions)
            {
                var result = (int[]) Invoke(solution, new object[] {"sea", "eat"});
                ;
            }
        }
    }
}