using System.Linq;
using Xunit;

namespace LeetCodes.Test
{
    public class A001TwoSumTest : TestTemplate
    {
        [Fact]
        public void ExampleTest()
        {
            var data = new[] {3,2,4};
            var target = 6;

            foreach (var solution in Solutions)
            {
                var result = (int[]) Invoke(solution, new object[] {data, target});
                Assert.True(result.SequenceEqual(new[] {1, 2}));
                
                
            }
        }
    }
}