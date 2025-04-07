namespace leecode_pratise.easy;
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class MaxDepthProblem
{
    /// <summary>
    /// 二叉树最大深度
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MaxDepth(TreeNode root) 
    {
        if (root ==null)
        {
            return 0;
        }

        if (root.left == null && root.right == null)
        {
            return 1;
        }

        return Math.Max(MaxDepth(root.left) , MaxDepth(root.right)) + 1;
    }
}