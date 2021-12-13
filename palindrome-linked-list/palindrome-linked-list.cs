/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        List<int> list = new List<int>();
         list.Add(head.val);
            ListNode nextNode = head.next;
            while(nextNode!=null)
            {
                list.Add(nextNode.val);
                nextNode = nextNode.next;
            }

            int idx = list.Count-1;
            for(int i=0;i<list.Count;i++)
            {
                if(list[i]!=list[idx-i])
                {
                    return false;
                }
            }
            return true;
    }
}