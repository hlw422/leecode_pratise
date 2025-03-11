using System.Text;
namespace leecode_pratise.huawei;

public class C20250306
{
    /// <summary>
    /// 单词倒排
    /// </summary>
    static void HJ31()
    {
        string line = Console.ReadLine();
        StringBuilder stringBuilder = new StringBuilder();
        List<string> list = new List<string>();
        int start = 0;
        for (int i = 0; i < line.Length; i++)
        {
            if ((line[i] >= 'a' && line[i] <= 'z') || (line[i] >= 'A' && line[i] <= 'Z'))
            {
                stringBuilder.Append(line[i]);
            }
            else
            {
                stringBuilder.Append(' ');
            }
        }
        string[] split = stringBuilder.ToString().Split(' ');
        for (int i = split.Length - 1; i >= 0; i--)
        {
            Console.Write(split[i] + " ");
        }
    }

    /// <summary>
    /// 合唱队
    /// </summary>
    static void HJ24()
    {
        string line = Console.ReadLine();
        int count = 0;
        List<int> dic = new List<int>();
        for (int i = 0; i < int.Parse(line); i++)
        {
            dic.Add(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < dic.Count; i++)
        {
            for (int j = i + 1; j < dic.Count; j++)
            {
                if (dic[i] > dic[j])
                {
                    int temp = dic[i];
                    dic[i] = dic[j];
                    dic[j] = temp;
                    count++;
                    break;
                }
            }
        }
        Console.WriteLine(count);
    }

    /// <summary>
    /// 删除字符串中出现次数最少的字符
    /// </summary>
    static void HJ23()
    {
        string line = Console.ReadLine();
        Dictionary<char, int> dic = new Dictionary<char, int>();
        for (int i = 0; i < line.Length; i++)
        {
            if (dic.ContainsKey(line[i]))
            {
                dic[line[i]]++;
            }
            else
            {
                dic.Add(line[i], 1);
            }
        }
        var result = dic.OrderBy(x => x.Value);
        int min = result.First().Value;
        foreach (var item in line)
        {
            if (dic[item] != min)
            {
                Console.Write(item);
            }
        }
    }

    //汽水瓶
    static void HJ22()
    {
        int result = 0;
        int add = 0;
        List<int> data = new List<int>();
        List<int> count = new List<int>();
        while (true)
        {
            string line = Console.ReadLine();
            if (int.Parse(line) == 0)
            {
                break;
            }
            data.Add(int.Parse(line));
        }
        for (int i = 0; i < data.Count; i++)
        {
            int k = data[i];
            while (k + add >= 3)
            {
                k = k - 3;
                add++;
                result++;
            }
            if (k + add == 2)
            {
                result++;
            }
            Console.WriteLine(result);
            result = 0;
            add = 0;
        }
    }

    /// <summary>
    /// 简单密码
    /// </summary>
    static void HJ21()
    {
        string line = Console.ReadLine();
        Dictionary<string, int> dp = new Dictionary<string, int>();
        dp.Add("abc", 2);
        dp.Add("def", 3);
        dp.Add("ghi", 4);
        dp.Add("jkl", 5);
        dp.Add("mno", 6);
        dp.Add("pqrs", 7);
        dp.Add("tuv", 8);
        dp.Add("wxyz", 9);
        string result = "";
        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] >= '0' && line[i] <= '9')
            {
                result += int.Parse(line[i].ToString());
            }
            else if (line[i] >= 'a' && line[i] <= 'z')
            {
                foreach (var item in dp)
                {
                    if (item.Key.Contains(line[i]))
                    {
                        result += item.Value;
                        break;
                    }
                }
            }
            else if (line[i] >= 'A' && line[i] <= 'Y')
            {
                result += (char)(line[i].ToString().ToLower()[0] + 1);
            }
            else
            {
                result += "a";
            }
        }
        Console.WriteLine(result);
    }
}