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
    public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> avarage = new List<double>();
            if (root == null )return avarage; 
            Queue<KeyValuePair<TreeNode, int>> Nodes = new Queue<KeyValuePair<TreeNode, int>>();
            
            Nodes.Enqueue(new KeyValuePair<TreeNode, int>(root, 0));
            avarage.Add(root.val);
            double sum = 0;
            double num = 0;
            int level = 0;


            while (Nodes.Count > 0)
            {
                KeyValuePair<TreeNode, int> mynode = Nodes.Dequeue();
                if (mynode.Value != level)
                {
                    avarage.Add(sum / num);
                    sum = 0;
                    num = 0;
                    level  = mynode.Value ; 
                }
                if (mynode.Key.left != null)
                {
                    Nodes.Enqueue(new KeyValuePair<TreeNode, int>(mynode.Key.left, mynode.Value + 1));
                    sum += mynode.Key.left.val;
                    num++;
                }
                if (mynode.Key.right != null)
                {
                    Nodes.Enqueue(new KeyValuePair<TreeNode, int>(mynode.Key.right, mynode.Value + 1));
                    sum += mynode.Key.right.val;
                    num++;
                }
            }





            return avarage;
        }
}