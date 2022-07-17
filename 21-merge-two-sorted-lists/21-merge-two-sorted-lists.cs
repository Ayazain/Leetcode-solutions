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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head  = null ;
        ListNode tail = new ListNode();
        
     while (list1!= null &&list2!=null)
     {
         Console.WriteLine("List1 = " + list1.val);
         Console.WriteLine("List2 = " + list2.val);
         Console.WriteLine("tail = " + tail.val);
         if(list1.val <= list2.val)
         {
            tail.next= list1;
             list1 =list1.next;
         }
         else 
         {
             tail.next=list2; 
             list2= list2.next;
                 
         }  
         if(head == null)
             head = tail;
         tail = tail.next;
     }
        while (list2 != null)
        { 
        // Console.WriteLine("List1** = " + list1.val);
         Console.WriteLine("List2 **= " + list2.val);
         Console.WriteLine("tail **= " + tail.val);
            tail.next= list2;
            list2= list2.next;
            if(head == null)
             head = tail;
             tail = tail.next;
        }
          while (list1 != null)
        { 
            tail.next= list1;
            list1= list1.next;
            if(head == null)
             head = tail;
               tail = tail.next;
        }
     if( head != null)  
         head =head.next;
        return head;
    }
}