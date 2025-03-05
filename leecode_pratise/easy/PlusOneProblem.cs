namespace leecode_pratise.easy;

public class PlusOneProblem
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            //从后往前遍历，如果是9就变成0，不是9就加1
            if (digits[i] == 9)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i]++;
                return digits;
            }
        }
        //如果第一个是0，说明是都9的情况，需要进位
        if (digits[0]==0)
        {
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
        return digits;
    }
}