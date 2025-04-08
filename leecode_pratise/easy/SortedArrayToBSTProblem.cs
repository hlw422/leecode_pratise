namespace leecode_pratise.easy;

public class SortedArrayToBSTProblem
{
    public TreeNode SortedArrayToBST(int[] nums) {
        return SortedArrayToBST(nums,0,nums.Length-1);
    }

    public TreeNode SortedArrayToBST(int[] nums, int start, int end)
    {
        if (end < start)
        {
            return null;
        }

        int mid = start+(end - start) / 2;
        TreeNode root = new TreeNode(nums[mid]);
        root.left = SortedArrayToBST(nums, start, mid - 1);
        root.right = SortedArrayToBST(nums, mid + 1, end);
        return root;
    }
}