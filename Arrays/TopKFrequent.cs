public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int,int> dic = new();
        foreach(int num in nums)
        {
            if(!dic.ContainsKey(num))
            {
                dic[num] = 1;
            }
            else
            {
                dic[num]++;
            }
        }        

        PriorityQueue<int,int> q = new();

        foreach(var pair in dic)
        {
            int key = pair.Key;
            int count = pair.Value;

            q.Enqueue(key,count);

            if(q.Count > k)
            {
                q.Dequeue();
            }
        }

        int[] arr = new int[q.Count];
        int i = 0;
        while(q.Count > 0)
        {
            arr[i++] = q.Dequeue();
        }
        return arr;
    }
}
