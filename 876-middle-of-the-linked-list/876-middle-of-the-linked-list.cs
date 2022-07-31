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
    public ListNode MiddleNode(ListNode head) {
         ListNode tmphead = head;
            ListNode result= head;
            int wholeCnt = 0;
            int midCnt;
            int tmpCnt = 1;
            if (head != null)
            {
                wholeCnt = 1;
            }
            else return null;
           
            //전체 노드의 갯수 구하기.
            while(tmphead.next!=null)
            {
                tmphead = tmphead.next;
                wholeCnt++;
            }
       
            midCnt = (wholeCnt / 2) + 1;
            

            while(tmpCnt<midCnt)
            {
                result = result.next;
                tmpCnt++;
            }

            return result;
    }
}