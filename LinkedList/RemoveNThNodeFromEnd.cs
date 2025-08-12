public class Solution 
{
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        if(head == null) return head;
        ListNode curr = head;
        int size = 0;
        while(curr != null)
        {
            
            size++;
            curr = curr.next;
            
        }

        if (n == size)
        {
            return head.next;
        }
        
        curr = head;
        for(int i = 0; i < size - n - 1; ++i)
        {
            curr = curr.next;
        }

        curr.next = curr.next.next;
        return head;
    }
}
