public class Solution 
{
    public ListNode SwapNodes(ListNode head, int k) 
    {
        ListNode curr = head;
        ListNode curr1 = head;
        int size = 0;
        while(curr1 != null)
        {
            curr1 = curr1.next;
            size++;
        }

        for(int i = 0; i < k - 1; ++i)
        {
            curr = curr.next;
        }

        ListNode tmp = head;
        

        for(int i = 0; i < size - k; ++i)
        {
            tmp = tmp.next;
        }

        (curr.val,tmp.val) = (tmp.val,curr.val);
        return head;
    }
}
