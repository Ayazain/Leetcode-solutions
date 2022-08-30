/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
 SortedList<int, int > sortedlist = new SortedList<int, int>(); 
   public int KthSmallest(TreeNode root, int k) 
    {
         DFS(root);
        // sortedlist.Sort();
         if(sortedlist.Count>=k)
         return sortedlist.ElementAt(k-1).Key; 
         else return 0 ; 
    }
    private void DFS(TreeNode node )
    {
        if (node == null  )
        {
           
            return ;
        }
        else
        {
           sortedlist.Add(node.val, node.val);
           DFS(node.left);
           DFS(node.right);
        }
    }
}