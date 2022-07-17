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
    public bool HasCycle(ListNode head) {
         Console.WriteLine("Hello, World!");

        HashSet<ListNode> nums = new HashSet<ListNode>(); 
       if(head != null)
        while(head.next != null)
        {
            ListNode next = head.next;

            if(nums.Contains(head.next))
            return true ; 
            else 
            nums.Add(head.next); 
            head = head.next;
        }
        return false ; 
    }
}