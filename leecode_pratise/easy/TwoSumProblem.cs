namespace leecode_pratise.easy;

/**
 * 两数之和
 */
public class TwoSumProblem
{
    /*
     * 给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target  的那 两个 整数，并返回它们的数组下标。

       你可以假设每种输入只会对应一个答案，并且你不能使用两次相同的元素。

       你可以按任意顺序返回答案。



       示例 1：

       输入：nums = [2,7,11,15], target = 9
       输出：[0,1]
       解释：因为 nums[0] + nums[1] == 9 ，返回 [0, 1] 。
       示例 2：

       输入：nums = [3,2,4], target = 6
       输出：[1,2]
       示例 3：

       输入：nums = [3,3], target = 6
       输出：[0,1]


       提示：

       2 <= nums.length <= 104
       -109 <= nums[i] <= 109
       -109 <= target <= 109
       只会存在一个有效答案
     */
    
    /**
     * 双层循环
     * 每个数与后面的数分别求和
     */
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return null;
    }

    /**
     * 空间换时间，一层循环
     */
    public int[] TwoSum_Hash(int[] nums, int target)
    {
        //使用字典表缓存数据
        Dictionary<int, int> hash = new Dictionary<int, int>(nums.Length - 1);
        for (int i = 0; i < nums.Length; i++)
        {
            //与缓存的数匹配上了，直接返回。
            if (hash.ContainsKey(target - nums[i]))
            {
                return new int[] { hash[target - nums[i]], i };
            }
            //缓存当前的数在第几个位置
            hash.Add(nums[i], i);
        }

        return null;
    }
}