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
    public ListNode ReverseList(ListNode head) {
       ListNode curr = head;
       ListNode prev = null;

       while(curr != null)
       {
          var temp = head.next;

          head.next = prev;
          
          prev = curr;
          curr = temp;
          head = curr;

       }

       return prev;
    }
}
