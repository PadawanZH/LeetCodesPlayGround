namespace LeetCodes
{
    public class A024SwapNodesInPair
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode p1 = head, p2 = head?.next;
            if (p1 == null || p2 == null)
            {
                return p1;
            }

            ListNode p3 = SwapPairs(p2.next);
            p1.next = p3;
            p2.next = p1;
            return p2;
        }
    }
}