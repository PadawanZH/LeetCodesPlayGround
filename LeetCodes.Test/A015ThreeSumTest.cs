using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace LeetCodes.Test
{
    public class A015ThreeSumTest : TestTemplate
    {
        [Fact]
        public void ExampleTest()
        {
            var nums = new [] {-4,-2,-2,-2,0,1,2,2,2,3,3,4,4,6,6};
            foreach (var solution in Solutions)
            {
                var result = (List<IList<int>>)Invoke(solution, new object[] {nums});
                
                Assert.Equal(new[] {-1, -1, 2}, result[0]);
                Assert.Equal(new[] {-1, 0, 1}, result[1]);
            }
        }
    }
}