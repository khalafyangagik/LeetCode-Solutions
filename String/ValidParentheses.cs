public class Solution 
{
    public bool IsValid(string s) 
    {
        Stack<char> chars = new Stack<char>();

        foreach(var c in s)
        {
            if(c == '{' || c == '[' || c == '(')
            {
                chars.Push(c);
            }

            else
            {
                if(chars.Count == 0) return false;
                if(c == '}' && chars.Pop() != '{') return false;
                if(c == ')' && chars.Pop() != '(') return false;
                if(c == ']' && chars.Pop() != '[') return false;
            }
        }
        return chars.Count == 0;
    }
}
