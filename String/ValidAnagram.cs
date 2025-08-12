public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length) 
        {
            return false;
        }

        int[] arr = new int[26];

        for(int i = 0; i < s.Length; ++i)
        {
            arr[s[i] - 'a']++;
        }

        for(int j = 0; j < t.Length; ++j)
        {
            arr[t[j] - 'a']--;
            if(arr[t[j] - 'a'] < 0)
            {
                return false;
            }
        }

        return true;

    }
}
