namespace leecode_pratise.easy;

public class HasPathSumProblem
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null)
        {
            return false;
        }
        //减去当前节点的值
        targetSum -= root.val;
        //如果值为 0，并且为子节点
        if (targetSum == 0 && root.left == null && root.right == null)
        {
            return true;
        }
        //左右子树中有一个满足即可
        return HasPathSum(root.left, targetSum)|| HasPathSum(root.right, targetSum);
    }
    

}