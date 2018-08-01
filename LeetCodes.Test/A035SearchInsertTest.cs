using Xunit;

namespace LeetCodes.Test
{
    public class A035SearchInsertTest : TestTemplate
    {
        [Fact]
        public void ExampleTest()
        {
            foreach (var solution in Solutions)
            {
                var result = (int[]) Invoke(solution, new object[] {new []{1, 3, 4, 5}, 0});
                Assert.Equal(new int[]{3, 4}, result);
            }
        }
    }
}