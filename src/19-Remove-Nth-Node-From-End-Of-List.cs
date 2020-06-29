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
// Runtime: 92 ms 77.09%
// Memory: 24.7 MB 57.62%
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        var ancor = new ListNode(0);
        ancor.next = head;
        
        var pre = ancor;
        var post = ancor;
        
        int gap = 0;        
        while(post.next != null) {
            post = post.next;
            if(gap < n) {
                gap++;
            }
            else {
                pre = pre.next;                
            }
        }
        
        pre.next = pre.next.next;
        
        return ancor.next;                
    }
}
