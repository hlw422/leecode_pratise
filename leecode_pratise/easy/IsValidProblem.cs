namespace leecode_pratise.easy;

public class IsValidProblem
{
    /// <summary>
    /// 有效的括号4ms击败29.19%
    /// 41.34MB击败54.49%
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public bool IsValid(string s)
    {
        /*

代码
测试用例
测试结果
测试结果
20. 有效的括号
已解答
简单
相关标签
相关企业
提示
给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串 s ，判断字符串是否有效。

有效字符串需满足：

左括号必须用相同类型的右括号闭合。
左括号必须以正确的顺序闭合。
每个右括号都有一个对应的相同类型的左括号。


示例 1：

输入：s = "()"

输出：true

示例 2：

输入：s = "()[]{}"

输出：true

示例 3：

输入：s = "(]"

输出：false

示例 4：

输入：s = "([{}])"

输出：true



提示：

1 <= s.length <= 104
s 仅由括号 '()[]{}' 组成
         */
        Dictionary<char, char> dic = new Dictionary<char, char>();
        dic.Add(')', '(');
        dic.Add(']', '[');
        dic.Add('}', '{');

        List<char> list = new List<char>();
        list.Add(s[0]);
        for (int i = 1; i < s.Length; i++)
        {
            //如果是左边符号，或者list没有数据了，直接加入list
            if (!dic.ContainsKey(s[i]) || list.Count == 0)
            {
                list.Add(s[i]);
            }
            //如果是右边符号，且list有数据，且list最后一个数据是对应的左边符号，删除list最后一个数据
            else if (list[list.Count - 1] == dic[s[i]])
            {
                list.RemoveAt(list.Count - 1);
            }
            //其他情况直接加入list
            else
            {
                list.Add(s[i]);
            }
        }
        //如果list没有数据，说明是有效的括号
        return list.Count == 0;
    }
}