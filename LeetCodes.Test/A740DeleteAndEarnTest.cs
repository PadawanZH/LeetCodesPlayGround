using Xunit;

namespace LeetCodes.Test
{
    public class A740DeleteAndEarnTest: TestTemplate
    {
        [Fact]
        public void Test()
        {
            foreach (var solution in Solutions)
            {
                var result = (int) Invoke(solution, new object[] {new []{3,4,2}});
                ;
            }
        }
    }
}