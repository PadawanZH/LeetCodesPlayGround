using Xunit;

namespace LeetCodes.Test
{
    public class A003LongestSubStringWithoutRepeatCharTest : TestTemplate
    {
        [Fact]
        public void ExampleTest()
        {
            string str = "abcabcbb";

            foreach (var solution in Solutions)
            {
                var result = (int) Invoke(solution, new object[] {str});
                Assert.Equal(3, result);
            }
        }
    }
}