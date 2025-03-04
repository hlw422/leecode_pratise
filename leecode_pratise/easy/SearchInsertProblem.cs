namespace leecode_pratise.easy;

public class SearchInsertProblem
{
    /// <summary>
    /// 搜索插入位置0ms击败100.00%

    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int SearchInsert(int[] nums, int target)
    {
        /*

代码
测试用例
测试结果
测试结果
35. 搜索插入位置
已解答
简单
相关标签
相关企业
给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。

请必须使用时间复杂度为 O(log n) 的算法。



示例 1:

输入: nums = [1,3,5,6], target = 5
输出: 2
示例 2:

输入: nums = [1,3,5,6], target = 2
输出: 1
示例 3:

输入: nums = [1,3,5,6], target = 7
输出: 4


提示:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums 为 无重复元素 的 升序 排列数组
-104 <= target <= 104
         */

        int left = 0;
        int right = nums.Length - 1;
        int mid = -1;
        while (left <= right)
        {
            mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
}