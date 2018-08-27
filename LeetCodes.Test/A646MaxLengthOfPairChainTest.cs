using Xunit;

namespace LeetCodes.Test
{
    public class A646MaxLengthOfPairChainTest : TestTemplate
    {
        [Fact]
        public void Test()
        {
            foreach (var solution in Solutions)
            {
                int[,] par = new int[3, 2]
                {
                    {3, 4},
                    {1, 2},
                    {2, 3},
                };
                
                var result = (int) Invoke(solution, new object[] {par});
            }
        }
    }
}