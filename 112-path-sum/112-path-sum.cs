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
      bool check(TreeNode node,  int sum , int targetSum  )
    {
        if (node == null)
            return  false ;
            sum+=node.val;
        if (node.left == null && node.right == null)
        { 
            if (sum == targetSum)
               return true;
               else return false  ;  
        
        }
    
         return(check(node.left, sum, targetSum)||check(node.right, sum , targetSum));

    }
      public bool HasPathSum(TreeNode root, int targetSum) {
      return check(root,0 ,  targetSum);   
    }
}