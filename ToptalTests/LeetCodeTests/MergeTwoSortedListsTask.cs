namespace ToptalTests.LeetCodeTests
{
    public class ListNode
    {
        public int Val;
        public ListNode Next;
        public ListNode(int val, ListNode next = null)
        {
            Val = val;
            Next = next;
        }
    }
    public class MergeTwoSortedListsTask
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            if (list1.Val < list2.Val)
            {
                list1.Next = MergeTwoLists(list1.Next, list2);
                return list1;
            }
            else
            {
                list2.Next = MergeTwoLists(list1, list2.Next);
                return list2;
            }
        }
    }
}
