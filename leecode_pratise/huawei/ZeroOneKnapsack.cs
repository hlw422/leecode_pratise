using System;

class ZeroOneKnapsack
{
    // 主程序
   public static void run()
    {
        // 物品重量和价值
        int[] weights = { 1, 3, 4 };
        int[] values  = { 15, 20, 30 };

        // 背包容量
        int capacity = 5;

        // 物品数量
        int n = weights.Length;

        int maxValue = Knapsack(weights, values, n, capacity);

        Console.WriteLine($"最大价值为: {maxValue}");
    }

    /// <summary>
    /// 0/1 背包问题 动态规划算法
    /// </summary>
    static int Knapsack(int[] weights, int[] values, int n, int capacity)
    {
        // 定义二维 DP 数组：dp[i,j] 表示前 i 件物品、容量 j 时的最大价值
        int[,] dp = new int[n + 1, capacity + 1];

        // 初始化：第 0 件物品或容量为 0 时，价值都是 0（默认值）

        // 遍历物品
        for (int i = 1; i <= n; i++)
        {
            // 当前物品的重量和价值（数组下标从 0 开始，所以 i-1）
            int weight = weights[i - 1];
            int value = values[i - 1];

            // 遍历容量
            for (int j = 0; j <= capacity; j++)
            {
                if (j < weight)
                {
                    // 装不下当前物品，继承上一个状态
                    dp[i, j] = dp[i - 1, j];
                }
                else
                {
                    // 装得下，选最大值（不放 or 放）
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - weight] + value);
                }

                // 打印调试信息（可选）
                // Console.WriteLine($"dp[{i},{j}] = {dp[i, j]}");
            }
        }

        // 返回最终结果
        return dp[n, capacity];
    }
}