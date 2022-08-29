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
      private int res = 0;

    public int PathSum(TreeNode root, int sum)
    {
        if (root == null)
            return res;

        DFS(root, sum, new List<double>());

        return res;
    }

    private void DFS(TreeNode node, int sum, List<double> paths)
    {
        if (node == null)
            return;

        paths.Add(0);

        for (int i = 0; i < paths.Count; i++)
        {
            paths[i] += node.val;

            if (paths[i] == sum)
                res++;
        }

        DFS(node.left, sum, new List<double>(paths));
        DFS(node.right, sum, new List<double>(paths));

    }
}