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
          
             Console.WriteLine(RIGHT+"<"+ node.val+"<" +LEFT) ;
                       Console.WriteLine(RIGHT<node.val) ;
                                 Console.WriteLine(node.val<LEFT) ;


          if(node.val<=RIGHT || node.val>=LEFT)
          {
                        
              return false ;
          }
          int val  = node.val; 
            Console.WriteLine(val);
         return  check(node.right ,  node.val , LEFT)&check(node.left , RIGHT , node.val) ; 
       
    }
    public bool IsValidBST(TreeNode root)
    {
        bool valid = true;
        
         if (root.left == null && root.right == null)
            return true;
   valid=  check(root , double.NegativeInfinity, double.PositiveInfinity );
        return valid;
    }

}