using System.Collections.Generic;

namespace LeetCodes
{
    public class A019DeleteNthElement
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n) {
            List<ListNode> pointer = new List<ListNode>();
            ListNode dummyHead = new ListNode(0);
            dummyHead.next = head;
            pointer.Add(dummyHead);
            while (head != null)
            {
                ListNode temp = head;
                pointer.Add(temp);
                head = head.next;
            }
            
            pointer.Add(null);

            if (pointer.Count == 1)
            {
                return null;
            }
            int startIndex = pointer.Count - n - 2;
            
            pointer[startIndex].next = pointer[startIndex + 2];
            return pointer[0].next;
        }
    }
}