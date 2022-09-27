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
    public ListNode RemoveElements(ListNode head, int val) {
      ListNode dommy  = new ListNode(0 , head);
        ListNode curr , prev ; 
        prev = dommy ; 
        curr = head  ; 
        while (curr!= null )
        {
            ListNode next = curr.next ; 
            if (curr.val == val)
              prev.next = next  ;  
            
            else 
              prev = curr ;   
            
            curr = next  ; 
        }
         return dommy.next ; 
    }
}