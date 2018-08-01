using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeetCodes
{
    public class A021MergeTwoSortedList
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode header = new ListNode(0);
            ListNode temp = header;
            
            while (l1 != null && l2 != null)
            {
                temp.next = ChangeNext(ref l1, ref l2);
                temp = temp.next;
            }

            ListNode remain = l1 ?? l2;
            while (remain != null)
            {
                temp.next = remain;
                temp = temp.next;
                remain = remain.next;
            }

            return header.next;
        }

        public ListNode ChangeNext(ref ListNode l1, ref ListNode l2)
        {
            int temp;
            if (l1.val < l2.val)
            {
                temp = l1.val;
                l1 = l1.next;
            }
            else
            {
                temp = l2.val;
                l2 = l2.next;
            }

            return new ListNode(temp);
        }

        public ListNode MergeTwoListsRecuisive(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode ans;
            if (l1.val < l2.val)
            {
                ans = new ListNode(l1.val);
                ans.next = MergeTwoListsRecuisive(l1.next, l2);
            }
            else
            {
                ans = new ListNode(l2.val);
                ans.next = MergeTwoListsRecuisive(l1, l2.next);
            }

            return ans;
        }
    }
}