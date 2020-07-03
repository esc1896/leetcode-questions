/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
// Rnntime: 96ms
// Memory Usage: 23.MB

public class Solution {
    public bool HasCycle(ListNode head) {
        
        bool rst = false;        
        if(head == null || head.next == null)
        {
            return false;
        }
        
        ListNode fast = head, slow = head;        
        while(fast.next != null && fast.next.next !=null && slow.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            if(fast == slow)
            {
                rst = true;
                break;
            }
        }
                                
        return rst;        
    }
}