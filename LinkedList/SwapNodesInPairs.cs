public class Solution 
{
    public ListNode SwapPairs(ListNode head) 
    
    {
        ListNode dummy = new ListNode(0);
        ListNode prev = dummy;
        dummy.next = head;

        while(head!= null && head.next != null)
        {
            ListNode first = head;
            ListNode second = head.next;

            prev.next = second;
            first.next = second.next;
            second.next = first;

            prev = first;
            head = first.next;
        }
        return dummy.next;
        

    }
}
