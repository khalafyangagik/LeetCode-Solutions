public class Solution 
{
    public ListNode SortList(ListNode head) 
    {
        ListNode slow = head;
        ListNode fast = head;

        if(head == null || head.next == null)
        {
            return head;
        }

        while(fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode mid = slow;
        ListNode right = mid.next;
        mid.next = null;
        ListNode left = head;
        return Merge(SortList(left),SortList(right));
    }

    static ListNode Merge(ListNode left,ListNode right)
    {
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        while(left != null && right != null)
        {
            if(left.val < right.val)
            {
                tail.next = left;
                left = left.next;
            }

            else
            {
                tail.next = right;
                right = right.next;
            }

            tail = tail.next;
        }

        if(left != null)
        {
            tail.next = left;
        }

        if(right != null)
        {
            tail.next = right;
        }

         return dummy.next;
    } 
}
      

