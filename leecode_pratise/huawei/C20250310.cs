namespace leecode_pratise.huawei;

public class C20250310 {

    /// <summary>
    /// 字母异位词分组
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        IList<IList<string>> result = new List<IList<string>>();
        
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
        
        for(int i = 0; i < strs.Length;i++)
        {
            var s = new string(strs[i].Order().ToArray());
            if (!groups.ContainsKey(s))
            {
                groups.Add(s, new List<string>{strs[i]});
            }
            else
            {
                groups[s].Add(strs[i]);
            }
            
        }
        //List<string>转成 IList<String>
        return groups.Select(t => t.Value).Cast<IList<string>>().ToList();

    }

    /// <summary>
    /// 购物单
    /// </summary>
    static void HJ16()
    {
        string line = Console.ReadLine();

        int jeall = int.Parse(line.Split(' ')[0]);
        int capacity = int.Parse(line.Split(' ')[1]);
        
        List<Item>items=new List<Item>();

        for (int i = 0; i < capacity; i++)
        {
            line = Console.ReadLine();
            //价格
            int price = int.Parse(line.Split(' ')[0]);
            //重要度
            int value = int.Parse(line.Split(' ')[1]);
            //主件编号
            int mainNo = int.Parse(line.Split(' ')[2]);
            
            items.Add(new Item{price =price,value = value,mainNo = mainNo});
            
        }
        //金额<总金额
        for (int i = 0; i < capacity; i++)
        {
            
        }
    }
}

public class Item
{
    //价格
     public int price{get;set;}
     //重要度
     public int value{get;set;}
     //主件编号
     public int mainNo{get;set;}
}