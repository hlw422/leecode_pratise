namespace leecode_pratise.easy;

/// <summary>
/// 爬楼梯问题
/// </summary>
public class ClimbStairsProblem
{
    public int ClimbStairs(int n)
    {
        int[] meno = new int[n + 1];
        return func(n, meno);
    }

    public int func(int n, int[] memo)
    {
        if (memo[n] > 0)
        {
            return memo[n];
        }

        if (n == 1||n==2)
        {
            memo[n] = n;
        }
        else
        {
            memo[n] = func(n - 1, memo)+func(n-2,memo);
        }
        return memo[n];
    }
}