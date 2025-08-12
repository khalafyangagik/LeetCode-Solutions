public class Solution 
{
    public IList<string> BinaryTreePaths(TreeNode root) 
    {
        IList<string> res = new List<string>();
        string path = "";
        dfs(root,path,res);
        return res;
    }

    public void dfs(TreeNode node,string path,IList<string> res)
    {
        if(node == null) return;
        
        path += node.val;

        if(node.left == null && node.right == null)
        {
            res.Add(path);
            return;
        }

        path += "->";
        dfs(node.left,path,res);
        dfs(node.right,path,res);

    }
}
