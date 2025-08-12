public class Solution 
{
    public int FirstUniqChar(string s) 
    {
        char[] chars = s.ToCharArray();
        Dictionary<char,int> dic = new Dictionary<char,int>();
        
        for(int i = 0; i < chars.Length; ++i)
        {
            char c = s[i];
            if(dic.ContainsKey(chars[i]))
            {
                dic[c]++;
            }

            else 
            {
                dic[c] = 1;
            }
        }

        for(int i = 0; i < s.Length; ++i)
        {
            if(dic[s[i]] == 1) return i;
        }

        return -1;

    }
}
