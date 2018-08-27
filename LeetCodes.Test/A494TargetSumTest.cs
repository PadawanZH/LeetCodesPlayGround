using Xunit;

namespace LeetCodes.Test
{
    public class A494TargetSumTest : TestTemplate
    {
        [Fact]
        public void Test()
        {
            foreach (var solution in Solutions)
            {
                var result = (int) Invoke(solution, new object[] {new []{1,1,1,1,1}, 3});
            }
        }
    }
}