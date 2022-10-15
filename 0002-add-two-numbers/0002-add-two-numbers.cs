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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
      ListNode res = new ListNode()  ; ListNode copy = res ; int count =0 ;
        while(l1!=null || l2!=null||count > 0 )
        { 
          int val  =0 ; 
          if (l1!= null ) {val+= l1.val ; l1 =l1.next;}
          if (l2!=null)   {val+=l2.val  ; l2= l2.next;}
          val+= count ; 
        count = val /10 ; 
        copy.next = new ListNode(val%10); 
        copy = copy.next ;
        }
     
        return res.next;
    }
}