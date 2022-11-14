/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    
    
   public  KeyValuePair<int, ListNode> GetLengthandTail(ListNode head)
    {
        int len = 0;
        while (head.next != null)
        {
            len++;
            head = head.next;
        }
        return new KeyValuePair<int, ListNode>(len, head);
    }
    public ListNode Cutoff(ListNode head, int len)
    {
        while (len > 0 && head != null)
        { head = head.next; len--; }
        return head;
    }
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null) return null;
        KeyValuePair<int, ListNode> tailA = GetLengthandTail(headA);
        KeyValuePair<int, ListNode> tailB = GetLengthandTail(headB);

        if (tailA.Value != tailB.Value) return null;

        ListNode shorter = (tailA.Key < tailB.Key) ? headA : headB;
        ListNode greater = (tailB.Key > tailA.Key) ? headB : headA;

        greater = Cutoff(greater, Math.Abs(tailA.Key - tailB.Key));
       while ( shorter!= greater  ) 
        {
           shorter= shorter.next ; 
         greater = greater.next ; 
        }
        return shorter;
    }
}