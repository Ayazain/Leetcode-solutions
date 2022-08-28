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
            return  false ;;
        if (node.left == null && node.right == null)
        { 
            sum+=node.val;
            Console.WriteLine(sum );
            if (sum == targetSum)
               return true;
               else return false  ;  
        
        }
        bool l = check(node.left, sum+node.val, targetSum) ;
        bool r = check(node.right, sum+node.val , targetSum);
       
         return(l||r);

    }
      public bool HasPathSum(TreeNode root, int targetSum) {
      return check(root,0 ,  targetSum);   
    }
}