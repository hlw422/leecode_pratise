namespace leecode_pratise.easy;

public class AddBinaryProblem
{
    /// <summary>
    /// 二进制求和
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public string AddBinary(string a, string b)
    {
        /*
         给你两个二进制字符串 a 和 b ，以二进制字符串的形式返回它们的和。



示例 1：

输入:a = "11", b = "1"
输出："100"
示例 2：

输入：a = "1010", b = "1011"
输出："10101"


提示：

1 <= a.length, b.length <= 104
a 和 b 仅由字符 '0' 或 '1' 组成
字符串如果不是 "0" ，就不含前导零
         */

        if (a.Length < b.Length)
        {
            a = a.PadLeft(b.Length, '0');
        }
        else
        {
            b = b.PadLeft(a.Length, '0');
        }
        string digits = "";
        int result = 0;
        int add = 0;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            result = a[i] - '0' + b[i] - '0' + add;
            add = result > 1 ? 1 : 0;
            digits = (result > 1 ? result - 2 : result) + digits;
        }
        if (add == 1)
        {
            digits = 1 + digits;
        }
        return digits;
    }


    /// <summary>
    /// 二进制求和
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public string AddBinaryTwoLength(string a, string b)
    {
        string digits = "";
        int result = 0;
        int add = 0;
        //双层循环，从后往前遍历，如果有一个字符串遍历完了，就用0代替
        for (int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0; i--, j--)
        {
            result = i >= 0 ? a[i] - '0' : 0;
            result += j >= 0 ? b[j] - '0' : 0;
            result += add;
            //%2取余数，/2取商
            digits = result % 2 + digits;
            add = result / 2;
        }
        if (add == 1)
        {
            digits = 1 + digits;
        }
        return digits;
    }
}