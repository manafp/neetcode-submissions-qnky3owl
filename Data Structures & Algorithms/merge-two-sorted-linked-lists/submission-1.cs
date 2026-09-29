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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var list = new ListNode();
        var head = list;
        while(list1 != null && list2 != null)
        {
            if(list1.val <= list2.val)
            {
                list.next = list1;
                list1 = list1.next;
                list = list.next;
            }
            else
            {
                list.next = list2;
                list2 = list2.next;
                list = list.next;
            }
        }
        if(list1 != null) list.next = list1;
        if(list2 != null) list.next = list2;

        return head.next;
    }
}