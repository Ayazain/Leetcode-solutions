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
    public ListNode Partition(ListNode head, int x) {
      if (head == null || head.next == null ) return head ; 
        
         ListNode beforStart = null  ; 
         ListNode BeforEnd = null  ; 
         ListNode AfterStart = null ; 
         ListNode AfterEnd = null  ;  
         ListNode MyValNode = null ; 
         ListNode node  = head  ;  
         while (node!= null )
         {
            ListNode next  = node.next ; 
          if(node.val< x  )
          {
       if (beforStart == null )
          { 
            beforStart = node  ; 
          BeforEnd = beforStart ; 
          }
          else
             {
                 BeforEnd.next = node ; BeforEnd = node  ; 
             } 
          }
          else if (node.val >= x )
            {
                if (AfterStart == null )
                { AfterStart = node  ; AfterEnd = node  ; }
                else  {AfterEnd.next = node  ; AfterEnd = node  ;  }
                AfterEnd.next = null ; 
            }
   node = next  ;
         }
         if (beforStart == null ) return AfterStart; 
        
        BeforEnd.next = AfterStart ;
    
   return beforStart; 
    }
}