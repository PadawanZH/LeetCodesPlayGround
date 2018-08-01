using Xunit;

namespace LeetCodes.Test
{
    public class A007ReverseIntegerTest : TestTemplate
    {
        [Fact]
        public void Test()
        {
            int x = 100;
            int y = -100;
            int z = 123;
            foreach (var solution in Solutions)
            {
                var resultx = (int) Invoke(solution, new object[] {x});
                Assert.Equal(1, resultx);
                var resulty = (int) Invoke(solution, new object[] {y});
                Assert.Equal(-1, resulty);
                var resultz = (int) Invoke(solution, new object[] {z});
                Assert.Equal(321, resultz);
            }
        }
    }
}