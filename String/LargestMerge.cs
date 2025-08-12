public class Solution 
{
    public string LargestMerge(string word1, string word2) 
    {
        StringBuilder sb = new StringBuilder();
        int i = 0, j = 0;
        while(i < word1.Length || j < word2.Length)
        {
            if(string.Compare(word1.Substring(i),word2.Substring(j)) > 0)
            {
                sb.Append(word1[i]);
                i++;
            }
            else 
            {
                sb.Append(word2[j]);
                j++;
            }
        }

        return sb.ToString();
     
    }
}
