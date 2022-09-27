
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
    public bool IsPalindrome(ListNode head) {
          ListNode  fast = head , slow = head  ; 
        Stack<ListNode>myque = new Stack<ListNode>() ; 
        myque.Push(slow) ; 
        while (fast.next!=null &&fast.next.next!= null )
        {
            slow = slow.next ;  
            fast=fast.next.next  ;
            myque.Push(slow) ; 
        }
        if (fast.next !=null ) slow = slow.next;
        else 
        {
           myque.Pop() ;
           slow = slow.next  ; 
        } 
       
        while(slow!=null)
        {
             ListNode curr= myque.Pop() ; ; 
            if (slow.val != curr.val )
            return false  ; 
            slow= slow.next ; 
        }
        return true ; 
    }
}