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
    public ListNode MergeKLists(ListNode[] lists) {
    
        if (lists == null || lists.Length == 0 )return null ; 
       else  if( lists.LongLength ==0) return null ;
        ListNode root = new ListNode(0);
        ListNode copy = root;
       
        PriorityQueue<ListNode, int> myqueue = new PriorityQueue<ListNode, int>((int)lists.LongLength);
        for (int i = 0; i < lists.Length; i++)
        {
         if(lists[i]!=null)  myqueue.Enqueue(lists[i], lists[i].val);
        }
        while (myqueue.Count > 0)
        {
            root.next = myqueue.Dequeue();
            root = root.next;
            if (root.next!=null)
                myqueue.Enqueue(root.next , root.next.val);
        }
        return copy.next;
    }
}