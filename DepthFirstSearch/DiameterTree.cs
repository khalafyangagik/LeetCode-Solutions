public class Solution 
{
    int max = 0;
    public int DiameterOfBinaryTree(TreeNode root) 
    {
        dfs(root);
        return max;
    }

    public int dfs(TreeNode node)
    {
        if(node == null) return 0;
        int left = dfs(node.left);
        int right = dfs(node.right);
      
        max = Math.Max(max,left + right);
        return Math.Max(left,right) + 1;
    }

}
