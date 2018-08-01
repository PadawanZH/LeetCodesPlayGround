using Xunit;

namespace LeetCodes.Test
{
    public class A034RangeSortedArrayTest : TestTemplate
    {
        [Fact]
        public void ExampleTest()
        {
            foreach (var solution in Solutions)
            {
                var result = (int[]) Invoke(solution, new object[] {new []{1, 1}, 1});
                Assert.Equal(new int[]{3, 4}, result);
            }
        }
    }
}