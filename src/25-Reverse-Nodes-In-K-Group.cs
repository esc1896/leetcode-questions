// Runtime: 96 ms
// Memory Usage: 24.2 MB

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (head == null
          || head.next == null
          || k == 1) return head;
        
        ListNode t = head;
        int i = 0;
        while(t != null && i < k-1)
        {
            t = t.next;
            i++;
        }        
        if(t == null) return head;
        
        ListNode rst = t;    

        ListNode h_ahead = new ListNode(0);
        h_ahead.next = head;        
        ListNode tmp = h_ahead.next;
        
        ReverseLinkedList(h_ahead, t);            
        h_ahead = tmp;
        t = h_ahead.next;
        if(t == null) return rst; // hit the end
        
        i = 0;
        while (t != null && t.next != null)
        {
            t = t.next;
            i++;
            if (i == k - 1)
            {
                tmp = h_ahead.next;
                ReverseLinkedList(h_ahead, t);
                h_ahead = tmp;
                t = h_ahead.next;
                i = 0;
            }
        }

        return rst;
    }

    // assume nodes are all valid
    private void ReverseLinkedList(ListNode h_ahead, ListNode t)
    {
        ListNode prev = new ListNode(0);
        ListNode cur = new ListNode(0);
        ListNode next = new ListNode(0);

        prev = h_ahead.next;
        cur = prev.next;

        prev.next = t.next;

        while (cur != null && cur != t)
        {
            next = cur.next;

            cur.next = prev;
            prev = cur;
            cur = next;
        }

        h_ahead.next = cur;
        cur.next = prev;
    }
}