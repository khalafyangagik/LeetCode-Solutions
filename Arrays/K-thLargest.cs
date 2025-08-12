public class Solution 
{
    private PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();
    public int FindKthLargest(int[] nums, int k) 
    {
        foreach(var item in nums)
        {
            minHeap.Enqueue(item,item);
            if(minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }
      
        return minHeap.Peek();
    }
}
