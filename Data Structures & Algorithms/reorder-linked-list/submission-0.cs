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
       var list = new List<ListNode>();

       ListNode curr = head;

       while(curr != null)
       {       
         list.Add(curr);
         curr = curr.next;
       }

       int l=0,r=list.Count -1;

       while(l<r)
       {
        list[l].next = list[r];
        l++;
        list[r].next = list[l];
        r--;
       }
        list[l].next = null;

    }
}
