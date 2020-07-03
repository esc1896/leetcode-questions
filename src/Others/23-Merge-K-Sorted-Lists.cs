/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

// First solution
// Runtime: 596 ms
// Memory Usage: 26.9 MB

public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        
        int listCount = lists.Length;
        if(listCount == 0) return null;
        if(listCount == 1) return lists[0];
        
        ListNode head = null, tmp = null;        
        while(true)
        {
            // look for min node        
            ListNode min = new ListNode(Int32.MaxValue);
            int minIndex = -1;
            for(int i = 0; i < listCount; i++)
            {
                if(lists[i] != null && lists[i].val < min.val)
                {
                    min.val = lists[i].val;
                    minIndex = i;                
                }
            }
            
            if(minIndex == -1) break;
                
            if(tmp == null)
            {
                tmp = lists[minIndex];
                head = tmp;
            }
            else
            {
                tmp.next = lists[minIndex];
                tmp = tmp.next;
            }

            lists[minIndex] = lists[minIndex].next;                
        }
                                
        return head;
    }
}