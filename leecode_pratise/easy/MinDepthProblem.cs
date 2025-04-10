namespace leecode_pratise.easy;

public class MinDepthProblem
{
    public int MinDepth(TreeNode root) 
    {
        if (root == null)
        {
            return 0;
        }

        return GetDepth(root, 0);

    }

    private int GetDepth(TreeNode root, int depth)
    {
        //节点为null,表示单边左子树为空，需要计算另一边的子树的深度
        if (root == null)
        {
            return int.MaxValue-1;
        }
        //如果是子节点，深度+1
        if (root.left == null && root.right == null)
        {
            return depth + 1;
        }
        //返回左子树的深度+右子树的深度 的最小值
        return Math.Min(GetDepth(root.left, depth)+1 , GetDepth(root.right, depth)+1);
    }
}