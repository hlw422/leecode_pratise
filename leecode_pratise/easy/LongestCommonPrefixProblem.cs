namespace leecode_pratise.easy;

public class LongestCommonPrefixProblem
{
    /// <summary>
    /// 最长公共前缀 4ms 击败 19.37%
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public string LongestCommonPrefix(string[] strs)
    {
        /*
         * 编写一个函数来查找字符串数组中的最长公共前缀。

如果不存在公共前缀，返回空字符串 ""。



示例 1：

输入：strs = ["flower","flow","flight"]
输出："fl"
示例 2：

输入：strs = ["dog","racecar","car"]
输出：""
解释：输入不存在公共前缀。


提示：

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] 如果非空，则仅由小写英文字母组成
         */
        /*
要找出字符串列表中所有字符串的最长公共前缀，可以按以下步骤进行：
首先判断列表是否为空，如果为空则直接返回空字符串。
以列表中的第一个字符串作为初始的公共前缀。
遍历列表中的其他字符串，将当前的公共前缀与每个字符串进行比较，不断更新公共前缀，直到遍历完所有字符串。
         */
        if (strs.Length == 0)
        {
            return "";
        }
        //取第一个字符串为前缀
        string prefix = strs[0];

        //判断prefix没有再变化了，就跳出循环。
        bool isBreak = true;

        while (isBreak)
        {
            isBreak = false;
            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].StartsWith(prefix))
                {
                    continue;
                }
                else
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    isBreak = true;
                    break;
                }
            }
        }
        return prefix;
    }
}