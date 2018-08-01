using System.Drawing;

namespace LeetCodes
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class A002AddTwoNumber
    {
        [Solution(IsSolution = false)]
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resultHeader = new ListNode(0);
            ListNode pointer = resultHeader;

            int nextAddUp = 0;

            while (l1 != null || l2 != null || nextAddUp != 0)
            {
                var curNode1 = (l1 == null) ? new ListNode(0) : l1;
                var curNode2 = (l2 == null) ? new ListNode(0) : l2;

                int sum = curNode1.val + curNode2.val + nextAddUp;
                nextAddUp = sum / 10;
                var newPointer = new ListNode(sum % 10);
                pointer.next = newPointer;
                pointer = newPointer;
                
                l1 = (l1 == null)? null: l1.next;
                l2 = (l2 == null)? null: l2.next;
            }

            return resultHeader.next;
        }
    }
}