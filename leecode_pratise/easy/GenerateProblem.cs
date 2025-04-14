namespace leecode_pratise.easy;

public class GenerateProblem
{
    /// <summary>
    /// 杨辉三角
    /// </summary>
    /// <param name="numRows"></param>
    /// <returns></returns>
    public IList<IList<int>> Generate(int numRows) 
    {
        var result = new List<IList<int>>();    
        IList<int> list = new List<int> { 1 };
        result.Add(list);
        for (int i = 1; i < numRows; i++)
        {
            //最左边的数
            var listNext = new List<int> { 1 };
            //中间的数=上一行数的第一个数+第二个数
            for (int k = 0; k < list.Count - 1; k++)
            {
                listNext.Add(list[k] + list[k + 1]);
            }
            //最右边的数
            listNext.Add(1);
            
            result.Add(listNext);
            list=listNext;
        }

        return result;
    }
}