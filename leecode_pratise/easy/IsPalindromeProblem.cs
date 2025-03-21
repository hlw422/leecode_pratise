namespace leecode_pratise.easy;

/*
 *9. 回文数
   已解答
   简单
   相关标签
   相关企业
   提示
   给你一个整数 x ，如果 x 是一个回文整数，返回 true ；否则，返回 false 。
   
   回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
   
   例如，121 是回文，而 123 不是。
    
   
   示例 1：
   
   输入：x = 121
   输出：true
   示例 2：
   
   输入：x = -121
   输出：false
   解释：从左向右读, 为 -121 。 从右向左读, 为 121- 。因此它不是一个回文数。
   示例 3：
   
   输入：x = 10
   输出：false
   解释：从右向左读, 为 01 。因此它不是一个回文数。
    
   
   提示：
   
   -231 <= x <= 231 - 1
    
   
   进阶：你能不将整数转为字符串来解决这个问题吗？
 * 
 */
public class IsPalindromeProblem
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        if (x == 0)
        {
            return true;
        }

        var str = x.ToString();
        
        var strlen = str.Length;

        for (var i = 0; i < strlen / 2; i++)
        {
            if (str[i] != str[strlen - i - 1])
            {
                return false;
            }
        }
        return true;
    }
    public bool IsPalindrome10(int x)
    {
        if (x < 0)
        {
            return false;
        }

        if (x % 10 == 0 && x != 0)
        {
            return false;
        }
        //反转数
        int revertedNumber = 0;
        while (x > revertedNumber)
        {
            //构造回文数
            revertedNumber = revertedNumber * 10 + x % 10;
            x = x / 10;
        }
        //偶数长度直接相等，奇数长度去掉最后一位
        return revertedNumber == x || revertedNumber / 10 == x;
    }
}