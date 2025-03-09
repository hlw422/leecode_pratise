namespace leecode_pratise.huawei;

public class question
{
    public static void Main1()
    {
        HJ15();
    }

    /// <summary>
    /// 购物单
    /// </summary>
    public static void HJ16()
    {
        
    }

    /// <summary>
    /// 求int型正整数在内存中存储时1的个数
    /// </summary>
    public static void HJ15()
    {
        string line = Console.ReadLine();
        string binary = Convert.ToString(Convert.ToInt32(line), 2);
        int count = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }

    /// <summary>
    /// 字符串排序
    /// </summary>
    public static void HJ14()
    {
        string line = Console.ReadLine();
        int count=int.Parse(line);
        List<string> list = new List<string>();
        for (int i = 0; i < count; i++)
        {
            list.Add(Console.ReadLine());
        }

        list.Sort(StringComparer.Ordinal);
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        
    }

    /// <summary>
    /// 句子逆序
    /// </summary>
    public static void HJ13()
    {
        string line = Console.ReadLine();
        string[] tokens = line.Split(' ');
        tokens= tokens.Reverse().ToArray();

        for (int i = 0; i < tokens.Length; i++)
        {
            Console.Write(tokens[i] + " ");
        }
    }

    /// <summary>
    /// 字符反转
    /// </summary>
    public static void HJ12()
    {
        string line = Console.ReadLine();
        line = new string(line.Reverse().ToArray());
        
        Console.WriteLine(line);
    }


/// <summary>
    /// 数字颠倒
    /// </summary>
    public static void HJ11()
    {
        string line = Console.ReadLine();
        line = new string(line.Reverse().ToArray());
        
        Console.WriteLine(line);
    }

    /// <summary>
    /// 字符个数统计
    /// </summary>
    public static void HJ10()
    {
        string line = Console.ReadLine();
        List<string>list=new List<string>();
        for (int i = 0; i < line.Length; i++)
        {
            if (!list.Contains(line[i].ToString()))
            {
                list.Add(line[i].ToString());
            }
        }
        Console.WriteLine(list.Count);
    }

    /*
     * 提取不重复的整数
     */
    public static void HJ9()
    {
        /*
         * 描述
           对于给定的正整数 
           n
           n ，按照从右向左的阅读顺序，返回一个不含重复数字的新的整数。
         */
        string line = Console.ReadLine();
        List<int> numbers = new List<int>();    
        for (int i = line.Length - 1; i >= 0; i--)
        {
            int number = int.Parse(line[i].ToString());
            if (!numbers.Contains(number))
            {
                numbers.Add(number);
            }
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i]);
        }
        
    }
    
    /// <summary>
    /// 合并表记录
    /// </summary>
    public static void HJ8()
    {
        /*
        数据表记录包含表索引和数值，请对表索引相同的记录进行合并，即将相同索引的数值进行求和运算，随后按照索引值的大小从小到大依次输出。
         */
        string line = Console.ReadLine();
        int count = int.Parse(line);
        SortedDictionary<int,int>Newdic=new SortedDictionary<int,int>();
        
        string []list=new string[count];    
        for (int i = 0; i < count; i++)
        {
            string s = Console.ReadLine();
            list[i] = s;
        }
        foreach (var item in list)
        {
            int index = int.Parse(item.Split(' ')[0]);
            int value = int.Parse(item.Split(' ')[1]);
            
            if (Newdic.ContainsKey(index))
            {
                Newdic[index] +=  value;
            }
            else
            {
                Newdic.Add(index, value);
            }
        }
        

        foreach (var item in Newdic)
        {
             Console.Write(item.Key+" "+item.Value);
             Console.WriteLine();
        }
        
    }

    /*
     取近似值 
     */
    public static void HJ7()
    {
        /*
         * 对于给定的正实数
           x
           x ，输出其四舍五入后的整数。更具体地说，若
           x
           x 的小数部分大于等于
           0.5
           0.5 ，则输出向上取整后的整数；否则输出向下取整后的整数。
         */
        string line = Console.ReadLine();

        decimal number = Convert.ToDecimal(line);
        if (number % 1 >= 0.5m)
        {
            Console.WriteLine((int)(number + 1));
        }
        else
        {
            Console.WriteLine((int)number);
        }
    }

    //分解质因数
    public static void HJ6()
    {
        string line = Console.ReadLine();
        int number = int.Parse(line);

        for (int i = 2; i * i <= number; i++){
            while (number % i == 0) {
                number = number / i;
                Console.Write(i+" ");
            }
        }

        if (number != 1)
        {
            Console.Write(number);
        }   
    }
    
}