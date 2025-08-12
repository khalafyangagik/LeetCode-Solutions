public class Solution 
{
    public TreeNode prev = null;

    public bool dfs(TreeNode root)
    {
        if(root == null) return true;
        bool left = dfs(root.left);
        
        if(prev != null && prev.val >= root.val)
        {
            return false;
        }
        prev = root;
        bool right = dfs(root.right);
        return left && right;
    }
    
    public bool IsValidBST(TreeNode root) 
    {
        return dfs(root);
    }
}
