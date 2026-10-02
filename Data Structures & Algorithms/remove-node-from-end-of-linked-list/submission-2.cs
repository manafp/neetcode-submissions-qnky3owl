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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        int count = 1;
        var curr = head;
        while(curr.next != null)
        {
            curr = curr.next;
            count++;
        }
        ListNode prev = null;
        curr = head;
        for( int i = 0; i < count - n ;i++)
        {
            prev = curr;
            curr = curr.next;
        }

        if(prev == null)
        {
            return curr.next;
        }

        prev.next = curr.next;

        return head;
    }
}
