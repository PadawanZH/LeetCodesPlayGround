using Xunit;

namespace LeetCodes.Test
{
    public class A647PalindromicSubString : TestTemplate
    {
        [Fact]
        public void ExampleTest()
        {
            foreach (var solution in Solutions)
            {
                var result = (int[]) Invoke(solution, new object[] {"aaaaa"});
                ;
            }
        }
    }
}