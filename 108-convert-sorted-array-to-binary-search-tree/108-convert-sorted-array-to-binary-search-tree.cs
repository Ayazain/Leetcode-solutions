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
 public TreeNode SortedArrayToBST(int[] nums) {
    TreeNode root  = Helpper(nums , 0  , nums.Length-1);
    return root ; 
    }
     public TreeNode Helpper (int[] nums  , int start  , int end   ) {
     if (start > end )
        return null ;
       int mid  = start +( (end -start )/2)  ; 
       TreeNode  root  = new TreeNode ( nums[mid]) ; 
       root.left  = Helpper(nums , start , mid-1) ; 
       root.right = Helpper(nums , mid+1 , end );
       return root; 



    }
}