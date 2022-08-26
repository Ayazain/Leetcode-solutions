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
      bool check(TreeNode node , double RIGHT  , double LEFT)
    {
          if(node == null ) return true  ; 
          if(node.val<=RIGHT || node.val>=LEFT)
          {
              return false ;
          }           
         return  check(node.left , RIGHT , node.val)&&check(node.right ,  node.val , LEFT) ; 
       
    }
    public bool IsValidBST(TreeNode root)
    {
        bool valid = true;
        
       
   valid=  check(root , double.NegativeInfinity, double.PositiveInfinity );
        return valid;
    }

}