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
        bool check(TreeNode node,  int sum ,List<int> nodesval , int targetSum , ref List<  IList<int >> sums  )
    {
        if (node == null)
            return  false ;
            sum+=node.val ;
            nodesval.Add(node.val); 
        if (node.left == null && node.right == null)
        { 
            Console.WriteLine(sum) ; 
            Console.WriteLine(sums.Count);
             if (sum == targetSum)
              { 
                   sums.Add(new List<int>(  nodesval));
                     nodesval.RemoveAt(nodesval.Count-1); 
                return true;
              }
              Console.WriteLine(sums.Count);
                  nodesval.RemoveAt(nodesval.Count-1); 
           return false  ;  
        
        }
        bool l = check(node.left, sum, nodesval,targetSum , ref sums) ;
        bool r = check(node.right, sum  ,nodesval, targetSum, ref sums);
            nodesval.RemoveAt(nodesval.Count-1); 
         return(l||r);

    }
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
  IList<IList<int>> ret  = new List<IList<int>>();
        List< IList<int>> vvvvvm = new List<IList<int>>() ; 

     bool ch =   check(root,0 , new List<int>(), targetSum ,ref vvvvvm); 
         return vvvvvm ;
    }
}