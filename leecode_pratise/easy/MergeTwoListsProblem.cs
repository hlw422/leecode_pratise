namespace leecode_pratise.easy;

public class MergeTwoListsProblem
{
    /*
 合并两个有序链表 0 ms 击败100.00%
 */
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        /*
         将两个升序链表合并为一个新的 升序 链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。

输入：l1 = [1,2,4], l2 = [1,3,4]
输出：[1,1,2,3,4,4]
示例 2：

输入：l1 = [], l2 = []
输出：[]
示例 3：

输入：l1 = [], l2 = [0]
输出：[0]

    两个链表的节点数目范围是 [0, 50]
    -100 <= Node.val <= 100
    l1 和 l2 均按 非递减顺序 排列

         */
        //创建一个空节点
        ListNode dummy = new ListNode();
        //创建一个移动指针指向这个空节点
        ListNode current = dummy;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                //移动指针的next指向新节点，用于与dummy链接起来
                current.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                current.next = new ListNode(list2.val);
                list2 = list2.next;
            }

            //移动指针移动到新节点
            current = current.next;
        }

        current.next = list1 == null ? list2 : list1;
        return dummy.next;
    }
    
    // 递归算法
    public ListNode MergeTwoListsDG(ListNode list1, ListNode list2)
    {
        if(list1 == null){        return list2;}
        if(list2 == null){        return list1;}

        if (list1.val < list2.val)
        {
            list1.next = MergeTwoListsDG(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = MergeTwoListsDG(list1, list2.next);
            return list2;
        }
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
    // 构建链表的方法
    public static ListNode BuildList(int[] values)
    {
        if (values.Length == 0) return null;
        ListNode dummy = new ListNode();
        ListNode current = dummy;
        foreach (int val in values)
        {
            current.next = new ListNode(val);
            current = current.next;
        }
        return dummy.next;
    }
    public static void PrintList(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.val + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}