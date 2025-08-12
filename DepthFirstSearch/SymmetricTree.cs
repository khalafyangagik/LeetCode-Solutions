public class Solution 
{
    public bool IsSymmetric(TreeNode root) 
    {
        return IsMirror(root.left, root.right);
    }

    public static bool IsMirror(TreeNode left, TreeNode right)
    {
        if(left == null && right == null) return true;
        if(left == null || right == null) return false;
        if(left.val != right.val) return false;
        bool a = IsMirror(left.left,right.right);
        bool b = IsMirror(left.right,right.left);
        return a && b;

    }
}
