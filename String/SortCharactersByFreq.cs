public class Solution 
{
    public string FrequencySort(string s) 
    {
             Dictionary<char,int> freq = new();
             foreach(char c in s)
             {
                if(!freq.ContainsKey(c))
                {
                    freq[c] = 0;
                }
                
                freq[c]++;
             }   
            
            PriorityQueue<char,int> pq = new();
            foreach(var pair in freq)
            {
                char c = pair.Key;
                int a = pair.Value;

                pq.Enqueue(c,-a);
            }

            StringBuilder sb = new StringBuilder();
            while(pq.Count > 0)
            {
                char c = pq.Dequeue();
                int count = freq[c];
                sb.Append(new string(c, count));
              
            }

            return sb.ToString();
            
     }
}
