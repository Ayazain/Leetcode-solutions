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
    public ListNode ReverseBetween(ListNode head, int left, int right) 
    {
         int counter = 1 ; 
         ListNode prevleft = null  ; 
         ListNode copy = head  ; 
        while(counter != left )
        {    
            prevleft = copy ; 
            copy = copy.next ;
            counter++; 
        }
        ListNode prev = null   ; 
        ListNode curr = copy ;  ListNode nxt = null ;
        while(counter-1 != right  )
        {
         nxt = curr.next; //null
         curr.next = prev ;  //null 
         prev = curr ;  // 5 
         curr = nxt  ;  //null
         counter++   ;
        }
        copy.next =  nxt ; 
        if (prevleft == null) return prev ; 
        else 
        {
            prevleft.next = prev ; 
            return head ; 
        }
    }
    
}