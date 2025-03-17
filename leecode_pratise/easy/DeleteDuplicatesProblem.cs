namespace leecode_pratise.easy;

public class DeleteDuplicatesProblem
{
    /*
     * 给定一个已排序的链表的头 head ， 删除所有重复的元素，使每个元素只出现一次 。返回 已排序的链表 。
     */
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null)
        {
            return null;
        }

        ListNode nextNode = head;

        while (nextNode.next != null)
        {
            if (nextNode.next.val == nextNode.val)//值一致，多跳一个
            {
                nextNode.next = nextNode.next.next;
            }
            else
            {
                //不一致，顺移一个
                nextNode = nextNode.next;
            }
        }
        //头部不动
        return head;
    }
}