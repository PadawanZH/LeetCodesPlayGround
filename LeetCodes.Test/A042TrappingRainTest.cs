using Xunit;

namespace LeetCodes.Test
{
    public class A042TrappingRainTest : TestTemplate
    {
        [Fact]
        public void ExampleTest()
        {
            foreach (var solution in Solutions)
            {
                var result = (int[]) Invoke(solution, new object[] {new []{0,1,0,2,1,0,1,3,2,1,2,1}});
                ;
            }
        }
    }
}