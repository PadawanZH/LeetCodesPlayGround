using Xunit;

namespace LeetCodes.Test
{
    public class A032LongestValidParenthesesTest  : TestTemplate
    {
        [Fact]
        public void ExampleTest()
        {
            foreach (var solution in Solutions)
            {
                var result = (ListNode) Invoke(solution, new object[] {"(()())"});
            }
        }
    }
}