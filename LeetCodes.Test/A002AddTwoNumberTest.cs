using System.Linq;
using Xunit;

namespace LeetCodes.Test
{
    public class A002AddTwoNumberTest : TestTemplate
    {
        [Fact]
        public void ExampleTest()
        {
            var listNode1 = new ListNode(2) {next = new ListNode(4) {next = new ListNode(3) {next = new ListNode(1)}}};
            var listNode2 = new ListNode(5) {next = new ListNode(6){next = new ListNode(4){next = new ListNode(1)}}};
            var resultNode = new ListNode(7) {next = new ListNode(0) {next = new ListNode(8) {next = new ListNode(2)}}};

            foreach (var solution in Solutions)
            {
                var result = (ListNode) Invoke(solution, new object[] {listNode1, listNode2});
                Assert.True(result.val == resultNode.val);
                Assert.True(result.next.val == resultNode.next.val);
                Assert.True(result.next.next.next.val == resultNode.next.next.next.val);
            }
        }
    }
}