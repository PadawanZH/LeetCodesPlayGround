using Xunit;

namespace LeetCodes.Test
{
    public class A025ReverseKGroupsTest
    {
        
        [Fact]
        public void Test()
        {
            A025ReverseKGroup a025ReverseKGroup = new A025ReverseKGroup();
            var listNode1 = new ListNode(2) {next = new ListNode(4) {next = new ListNode(3) {next = new ListNode(1)}}};
            a025ReverseKGroup.ReverseKGroup(listNode1, 2);
            Assert.Equal(4, listNode1.val);
        }
    }
}