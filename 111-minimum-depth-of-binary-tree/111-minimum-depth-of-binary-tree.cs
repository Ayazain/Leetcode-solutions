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
    public int MinDepth(TreeNode root) {
                if (root == null ) return 0; 
            Queue<KeyValuePair<TreeNode, int>> Nodes = new Queue<KeyValuePair<TreeNode, int>>();
            
            Nodes.Enqueue(new KeyValuePair<TreeNode, int>(root, 1));
         
        

            while (Nodes.Count > 0)
            {
                KeyValuePair<TreeNode, int> mynode = Nodes.Dequeue();
               
                 if (mynode.Key.left == null && mynode.Key.right ==  null )
                 {
                     return mynode.Value ; 
                 }

                if (mynode.Key.left != null)
                {
                    Nodes.Enqueue(new KeyValuePair<TreeNode, int>(mynode.Key.left, mynode.Value + 1)); 
                }
                if (mynode.Key.right != null)
                {
                    Nodes.Enqueue(new KeyValuePair<TreeNode, int>(mynode.Key.right, mynode.Value + 1));
                }
            }





            return 0;
    }
}