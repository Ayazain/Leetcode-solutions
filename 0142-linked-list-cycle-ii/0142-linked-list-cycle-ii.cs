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
public class Solution {
   public ListNode DetectCycle(ListNode head) {
        ListNode fast  = head  ; 
        ListNode slow  = head  ; 
        // detect  if there is a Cycle  
       while(fast!=null && fast.next!= null )
       {
        slow = slow.next ; 
        fast = fast.next.next ; 
        if (fast ==  slow)  break  ;  
       }
        if (fast==null || fast.next== null) return null; 
        fast = head  ; 
        while(fast!=slow )
       {
        fast = fast.next  ; 
        slow = slow.next ;  
       }
       return slow  ; 
    }
}