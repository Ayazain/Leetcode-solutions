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
      
 IList<int> ret  = new List<int>(); 
 Queue<TreeNode> parent = new Queue<TreeNode>(); 
    private void Find(TreeNode nood  , int k  )
    {
        if(nood == null )  return ;   
        if (k==0)
        {
         ret.Add(nood.val); 
         return ;    
        }
      else 
      {
        Find(nood.left, k-1); 
        Find(nood.right , k-1);
      }

    }
     private bool Findtarget(TreeNode root  ,TreeNode target )
    {
        if(root == null )  return false;   
        if (root.val == target.val)
        {
         return true ;    
        }
      else 
      {
    if(    Findtarget(root.left, target)|| Findtarget(root.right , target))
    {
        parent.Enqueue(root); 
        return true  ; 
    }
       return false ; 
      }

    }

   public IList<int> DistanceK(TreeNode root, TreeNode target, int k) {
       Find( target  ,  k  );
       Findtarget(root , target);
       int counter = 0  ; 
       TreeNode old = target  ;
         for (int i = 0 ; i < parent.Count ; i++)
           Console.WriteLine(parent.ElementAt(i).val);
       while(counter < k  && parent.Count>0)
       {

        TreeNode node  =   parent.Dequeue() ;  
        if(node.left != null )
        if (node.left.val ==  old.val) node.left = null; 
         if(node.right != null )
        if (node.right.val ==  old.val) node.right = null; 
             counter++;
        Find( node  ,  k-counter  );
         old = node ; 
      
       }
      
        return ret ; 
    }
}