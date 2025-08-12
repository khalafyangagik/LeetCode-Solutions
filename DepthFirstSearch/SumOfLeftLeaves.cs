public class Solution 
{
    public int SumOfLeftLeaves(TreeNode root) 
    {
        List<int> ints = new();
        dfs(root,ints);
        return ints.Sum();
    }

    public void dfs(TreeNode node,List<int> ints)
    {
        if(node == null) return;
        if(node.left != null && node.left.left == null && node.left.right == null)
        {
            ints.Add(node.left.val);
        }

        
        dfs(node.left,ints);
        dfs(node.right,ints);
    }
}
