namespace LeetCodes
{
    public class A023MergeKSortedList
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
            {
                return null;
            }

            ListNode ans = null;
            for (int i = 0; i < lists.Length; i++)
            {
                ans = MergeTwoListsRecuisive(ans, lists[i]);
            }

            return ans;
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