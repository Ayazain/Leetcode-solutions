/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    
    TreeNode  CommenAnsector ;  
    public KeyValuePair<bool, bool> FindCommenAnsector(TreeNode root, TreeNode p, TreeNode q)
    {

        if (root == null ) return new KeyValuePair<bool, bool>(false, false);

        bool key = false, value = false;
        if (root.val == p.val) key = true;
        else if (root.val == q.val) value = true;
        if (root.left != null)
        {
            KeyValuePair<bool, bool> leftRes = FindCommenAnsector(root.left, p, q);
            key = key | leftRes.Key;
            value = value | leftRes.Value;
        }
        if (root.right != null)
        {
            KeyValuePair<bool, bool> rightRes = FindCommenAnsector(root.right, p, q);
            key = key | rightRes.Key;
            value = value | rightRes.Value;
        }
        if (key && value)
        {
            CommenAnsector = root;
            key = false  ;  value = false ; 
        }
        return new KeyValuePair<bool, bool>(key, value);
    }
       public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
        FindCommenAnsector(root , p , q ) ; 
           return CommenAnsector ; 
         }
}