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
        
        var dic = new Dictionary<Node,Node>();
        var curr = head;
        while(curr != null)
        {
            var node = new Node(curr.val);
            dic[curr] = node;
            node.next = curr.next;
            node.random = curr.random;
            curr = curr.next;
        }
        curr = dic[head];
        while(curr != null)
        {
           curr.next = curr.next == null ? null : dic[curr.next];
           curr.random = curr.random == null ? null :dic[curr.random];
           curr = curr.next;
        }

        return dic[head];
    }
}
