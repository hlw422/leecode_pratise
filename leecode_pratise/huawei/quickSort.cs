namespace leecode_pratise.huawei;

/// <summary>
/// 快速排序
/// </summary>
public class quickSort
{
    public List<int> sort(List<int> lst)
    {
        if (lst.Count <= 1)
        {
            return lst;
        }

        int pivot = lst[0];
        List<int> small = new List<int>();
        List<int> large = new List<int>();

        for (int i = 1; i < lst.Count; i++)
        {
            if (pivot > lst[i])
            {
                small.Add(lst[i]);
            }
            else
            {
                large.Add(lst[i]);
            }
        }
        small=sort(small);
        large=sort(large);
        return merge(small,pivot,large);
        
    }

    public List<int> merge(List<int> small, int piviot, List<int> large)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < small.Count; i++)
        {
            result.Add(small[i]);
        }
        result.Add(piviot);
        for (int i = 0; i < large.Count; i++)
        {
            result.Add(large[i]);
        }
        return result;
    }

}