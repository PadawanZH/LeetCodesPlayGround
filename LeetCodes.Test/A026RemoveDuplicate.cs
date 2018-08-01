using Xunit;

namespace LeetCodes.Test
{
    public class A026RemoveDuplicate
    {
        [Fact]
        public void Test()
        {
            int[] a = new int[] {1, 1, 2, 2, 2, 3, 4, 4};
            LeetCodes.A026RemoveDuplicate a026RemoveDuplicate = new LeetCodes.A026RemoveDuplicate();
            var res = a026RemoveDuplicate.RemoveDuplicates(a);
            Assert.Equal(4, res);
        }
    }
}