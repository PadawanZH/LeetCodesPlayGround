using Xunit;

namespace LeetCodes.Test
{
    public class A033RotatedSortedArrayTest : TestTemplate
    {
        [Fact]
        public void ExampleTest()
        {
            foreach (var solution in Solutions)
            {
                var result = (int) Invoke(solution, new object[] {new []{0, 1}, 1});
                Assert.Equal(4, result);
            }
        }
    }
}