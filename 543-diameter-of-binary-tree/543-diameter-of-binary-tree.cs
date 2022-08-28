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
      int check(TreeNode node, ref int MAX)
    {
        if (node == null)
            return 0;
        if (node.left == null && node.right == null)
            return 1;
        int l = check(node.left, ref MAX);
        int r = check(node.right, ref MAX);
        if (l + r > MAX)
            MAX = l + r;
         return(Math.Max(l , r)+1);

    }
    public int DiameterOfBinaryTree(TreeNode root) {
       int max = 0;
         check(root, ref max);   
        return max;
    }
}