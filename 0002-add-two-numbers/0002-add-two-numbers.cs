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
        while(l1!=null && l2!=null)
        {
        int val = (l1.val+l2.val+count)%10  ; 
        count = (l1.val+l2.val+count)/10;
        copy.next = new ListNode(val); 
        copy = copy.next ; l1=l1.next ; l2= l2.next;
        }
        while(l1!=null )
        {
        int val = (l1.val+ count)%10 ; 
        count = (l1.val+count)/10;
        copy.next = new ListNode(val); 
        copy = copy.next ; l1=l1.next ;
        }
         while (l2!=null)
        {
          int val = (l2.val+ count)%10 ; 
        count = (l2.val+count)/10;
        copy.next = new ListNode(val); 
        copy = copy.next ; l2=l2.next ;;
        }
       if (count > 0 ) copy .next = new ListNode(count);
        return res.next;
    }
}