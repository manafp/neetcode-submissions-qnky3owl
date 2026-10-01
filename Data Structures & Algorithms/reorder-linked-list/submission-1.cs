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
    public void ReorderList(ListNode head) {
        var slow = head;
        var fast = head.next;
        while(fast !=null && fast.next != null)
        {
             slow = slow.next;
             fast = fast.next.next;           
        }
        ListNode prev = null;
        var curr = slow.next;
        slow.next = null;
        while(curr != null)
        {
            var temp = curr.next;

            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        
        var list1 = head;
        var list2 = prev;
 
        while(list2!=null)
        {
            var temp1 = list1.next;
            var temp2 = list2.next;

            list1.next = list2;
            list2.next = temp1;
            list1 = temp1;
            list2 = temp2;

        }

    }
}
