public class Solution 
{
    public static TreeNode dfs(TreeNode node)
    {
        if(node == null) return node;
        (node.left,node.right) = (node.right,node.left);
        dfs(node.left);
        dfs(node.right);
        return node;
    }

    public TreeNode InvertTree(TreeNode root) 
    {
        return dfs(root);
    }
}
