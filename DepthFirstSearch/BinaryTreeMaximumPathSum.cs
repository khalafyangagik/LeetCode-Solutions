public class Solution 
{
    private int res = int.MinValue;
    public int MaxPathSum(TreeNode root) 
    {
        dfs(root);
        return res;
    }
  
    public int dfs(TreeNode node)
    {
        if(node == null) return 0;
        int left = Math.Max(0,dfs(node.left));
        int right = Math.Max(0,dfs(node.right));
        res = Math.Max(res,left + right + node.val);
        return Math.Max(left,right) + node.val;
    }
}
