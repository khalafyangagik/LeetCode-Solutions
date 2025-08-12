public class Solution 
{
    public ListNode DeleteDuplicates(ListNode head) 
    {
        ListNode curr = head;
        ListNode dummy = new ListNode(0);
        ListNode prev = dummy;
        prev.next = head;

        while(curr != null)
        {
            if(curr.next != null && curr.val == curr.next.val)
            {
                while(curr.next != null && curr.val == curr.next.val)
                {
                    curr = curr.next;
                }
                prev.next = curr.next;
            }
        
            else 
            {
                prev = prev.next;
            }
        
        curr = curr.next;
        }
    
    return dummy.next;
    }
}
    
