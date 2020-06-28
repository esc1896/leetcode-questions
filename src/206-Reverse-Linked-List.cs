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
// Runtime: 88ms 93.65%
// Memory: 24.7 MB 15.83%
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        // recursively
        return ReverseListInt(head, null);
    }
    
    private ListNode ReverseListInt(ListNode head, ListNode newHead)
    {
        if(head == null) return newHead;
        
        var next = head.next;
        head.next = newHead;
        return ReverseListInt(next, head);        
    }
}

// Runtime: 88ms
// Memory: 24.4MB
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        // iteratively
        ListNode newHead = null;
        ListNode next = null;
    
        while(head != null)
        {
            next = head.next;
            head.next = newHead;
            newHead = head;
            head = next;
        }
        
        return newHead;
    }
}
