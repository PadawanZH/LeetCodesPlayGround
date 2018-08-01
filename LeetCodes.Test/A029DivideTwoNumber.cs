using Xunit;

namespace LeetCodes.Test
{
    public class A029DivideTwoNumber : TestTemplate
    {
        [Fact]
        public void ExampleTest()
        {
          

            foreach (var solution in Solutions)
            {
                var result = (ListNode) Invoke(solution, new object[] {-2147483648,2});
            }
        }
    }
}