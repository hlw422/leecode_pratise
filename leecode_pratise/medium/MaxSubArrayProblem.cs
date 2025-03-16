namespace leecode_pratise.medium;

/// <summary>
/// 最大子数组求和
/// </summary>
public class MaxSubArrayProblem
{
    public int MaxSubArray(int[] nums) {
        if (nums.Length == 0)
        {
            return 0;
        }
        var max = nums[0];//结果最大值
        var current = nums[0];//当前最大值
        for (int i = 1; i < nums.Length; i++)
        {
            //前面的数小于 0，则舍弃，从当前数开始
            if (current <= 0)
            {
                current = nums[i];
            }
            else
            {
                //前面的数大于0，则加上前面的数
                current += nums[i];
            }
            max = Math.Max(max, current);
        }

        return max;
    }
}