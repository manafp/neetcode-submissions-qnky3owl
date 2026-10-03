/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if(head == null)
            return null;
        Node curr = head;

        while(curr !=null)
        {
           Node copy = new Node(curr.val);
           copy.next = curr.next;
           curr.next = copy;
           curr = copy.next;
        }
        
        curr = head;

        while(curr != null)
        {
            if(curr.random != null)
            {
                curr.next.random = curr.random.next;
            }

            curr = curr.next.next;
        }
        curr = head;
        Node copyHead = head.next;

        while(curr != null)
        {
            var copy = curr.next;

            curr.next = copy.next;

            copy.next = copy.next?.next ?? null;

            curr = curr.next;
        }

        return copyHead;
    }
}
