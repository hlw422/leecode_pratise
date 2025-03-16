namespace leecode_pratise.easy;


 // Definition for a binary tree node.
/*
 *给你两棵二叉树的根节点 p 和 q ，编写一个函数来检验这两棵树是否相同。   
如果两个树在结构上相同，并且节点具有相同的值，则认为它们是相同的。
 */
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }

      public TreeNode CreateNode()
      {
          TreeNode newNode = new TreeNode(1);
          newNode.left=new TreeNode(2);
          newNode.right=new TreeNode(3);
          return newNode;
      }
  }

public class IsSameTreeProblem
{
    /*
     * 0ms击败100.00%
       
     */
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q != null)
        {
            return false;
        }

        if (p != null && q == null)
        {
            return false;
        }

        if (p == null && q == null)
        {
            return true;
        }

        if (p.val != q.val)
        {
            return false;
        }

        if (p.val == q.val)
        {
            //比较左子树与右子树是否相同
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }

        return false;
    }
}