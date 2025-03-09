namespace leecode_pratise.huawei
{
    public class MergeSort
    {
        public List<int> sort(List<int> lst)
        {
            if (lst.Count <= 1)
            {
                return lst;
            }

            int mid = lst.Count / 2;
            List<int> left = lst.GetRange(0, mid);
            List<int> right = lst.GetRange(mid, lst.Count - mid);

            left = sort(left);
            right = sort(right);

            return merge(left, right);
        }

        /// <summary>
        /// 合并已经排序好的两个子序列
        /// </summary>
        List<int> merge(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            int i = 0, j = 0;

            while (i < a.Count && j < b.Count)
            {
                if (a[i] <= b[j])
                {
                    result.Add(a[i]);
                    i++;
                }
                else
                {
                    result.Add(b[j]);
                    j++;
                }
            }

            // 剩余元素直接添加
            while (i < a.Count)
            {
                result.Add(a[i]);
                i++;
            }

            while (j < b.Count)
            {
                result.Add(b[j]);
                j++;
            }

            return result;
        }
    }
}