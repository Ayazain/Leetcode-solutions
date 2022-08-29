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
    TreeNode  root = null    ; 
     private TreeNode DFS(TreeNode node, TreeNode node2  )
    {
        if (node == null&& node2 == null)
            return null  ;

            TreeNode node3  = new TreeNode();
            TreeNode node1l = null  ;
            TreeNode node1r = null;
            TreeNode node2l = null ;
            TreeNode node2r = null ;
            if (root == null)
            root = node3;
            if (node != null )
            {
                node3.val += node.val; 
                node1l= node.left;
                node1r = node.right ; 
            }
           if (node2 != null )
            {
                node3.val += node2.val; 
                node2l = node2.left;
                node2r = node2.right; 
            }
      node3.left=   DFS(node1l, node2l);
     node3.right =    DFS(node1r , node2r);
return node3;
    }
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
          DFS(root1, root2);  
        return root; 
    }
}