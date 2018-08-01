using Xunit;

namespace LeetCodes.Test
{
    public class A043WildcardMatchingTest : TestTemplate
    {
        [Fact]
        public void ExampleTest()
        {
            foreach (var solution in Solutions)
            {
                var result = (int[]) Invoke(solution, new object[] {"zacabz", "*a?b*"});
                ;
            }
        }
    }
}