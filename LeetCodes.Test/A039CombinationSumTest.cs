using Xunit;

namespace LeetCodes.Test
{
    public class A039CombinationSumTest : TestTemplate
    {
        [Fact]
        public void ExampleTest()
        {
            foreach (var solution in Solutions)
            {
                var result = (int[]) Invoke(solution, new object[] {new []{2,3,6,7}, 7});
                ;
            }
        }
    }
}