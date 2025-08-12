public class Solution 
{
    public bool IsBalanced(TreeNode root) 
    {
        if(root == null) return true;
        int left = GetHeight(root.left);
        int right = GetHeight(root.right);
        if(Math.Abs(left - right) > 1) return false;
        return IsBalanced(root.left) && IsBalanced(root.right);
       
    }

    public static int GetHeight(TreeNode node)
    {
        if(node == null) return 0;
        int left = GetHeight(node.left);
        int right = GetHeight(node.right);
        return Math.Max(left, right) + 1;
    }

}
