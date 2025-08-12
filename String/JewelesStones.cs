public class Solution 
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        HashSet<char> hash = new HashSet<char>(jewels);
        int count = 0;
        for(int i = 0; i < stones.Length; ++i)
        {
            if(hash.Contains(stones[i]))
            {
                count++;
            }
        }
        return count;  
    }
}
