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
    
   List<int > sortedlist = new List<int>(); 
    public int KthSmallest(TreeNode root, int k) 
    {
         DFS(root);
         sortedlist.Sort();
         if(sortedlist.Count>=k)
         return sortedlist[k-1]; 
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
           sortedlist.Add(node.val);
           DFS(node.left);
           DFS(node.right);
        }
    }
}