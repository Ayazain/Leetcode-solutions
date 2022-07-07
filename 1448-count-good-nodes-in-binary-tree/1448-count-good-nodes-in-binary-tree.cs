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
    public int GoodNodes(TreeNode root) {
        return Checknodes(root , root.val);
        
    }
    
    	public int Checknodes(TreeNode node , int max )
	{
		if (node == null )
			return 0 ; 
		else 
		{
			if (node.val>=max)
				return ( 1 + Checknodes( node.left, node.val ) + Checknodes(node.right, node.val));
			else 
			{
			node.val = max ; 
			 return ( Checknodes( node.left, node.val ) + Checknodes(node.right, node.val));
			}
				
		}
	
	}
}