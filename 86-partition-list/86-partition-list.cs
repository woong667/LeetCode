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
    public ListNode Partition(ListNode head, int x) {
        
        
           if (head == null)
                return null;
            List<ListNode> left = new List<ListNode>();
            List<ListNode> right = new List<ListNode>();
            ListNode resultNext = new ListNode();
            ListNode resultHead = new ListNode();
            while (true)
            {
               if(head.val<x)
               {
                    left.Add(head);
               }
               else
               {
                    right.Add(head);
               }



               if (head.next == null)
                   break;
               else
               {
                   head = head.next;
               }
            }

            resultHead = resultNext;

            //left가 없지 않을때
            if (left.Count!=0)
            {
                
                resultNext.val = left[0].val;
                for(int i=1;i<left.Count;i++)
                {
                    resultNext.next = new ListNode(left[i].val,null);
                    resultNext = resultNext.next;
                }
                if(right.Count!=0)
                {
                    for(int i=0;i<right.Count;i++)
                    {
                        resultNext.next = new ListNode(right[i].val,null);
                        resultNext = resultNext.next;
                    }
                }
               
            }
            else //left가 없을때
            {
                resultNext.val = right[0].val;
                for (int i=1;i<right.Count;i++)
                {
                    resultNext.next = new ListNode(right[i].val,null);
                    resultNext = resultNext.next;
                }
            }
           
           
            return resultHead;
    }
}