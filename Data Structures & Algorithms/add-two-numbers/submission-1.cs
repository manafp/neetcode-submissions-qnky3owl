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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        int carry = 0;
        ListNode res = new ListNode();
        var dummy = res;
        ListNode prev = null;
        while(l1 != null || l2 != null)
        {
            int sum = 0;
            if(l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;

            }

            if(l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            sum = sum + carry;

            if(sum >= 10)
            {
                sum = sum % 10;
                carry = 1;
            } 
            else carry = 0;
            res.next = new ListNode(sum);
            prev = res.next;
            res = res.next;
        }

        if(carry != 0) prev.next = new ListNode(carry);
        return dummy.next;
    }
}
