namespace LeetCodes
{
    public class A025ReverseKGroup
    {
        [Solution(IsSolution = true)]
        public ListNode ReverseKGroup(ListNode head, int k) {
            ListNode[] operateGroup = new ListNode[k];
            
            for (int i = 0; i < k; i++)
            {
                if (head != null)
                {
                    operateGroup[i] = head;
                }
                else
                {
                    return (i == 0) ? null : operateGroup[0];
                }

                head = head.next;
            }
            
            for (int i = k-1; i > 0; i--)
            {
                operateGroup[i].next = operateGroup[i - 1];
            }
            
            operateGroup[0].next = ReverseKGroup(head, k);
            
            return operateGroup[k-1];
        }
    }
}