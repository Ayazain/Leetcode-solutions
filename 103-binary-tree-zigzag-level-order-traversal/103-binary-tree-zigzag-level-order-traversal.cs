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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        List<IList<int >> ret  =  new List<IList<int>>(); 
        Queue<KeyValuePair< TreeNode , int >> myqueue = new Queue<KeyValuePair<TreeNode , int>>();
        if(root == null ) return ret ; 
        myqueue.Enqueue( new KeyValuePair<TreeNode, int>(root , 0));
        IList<int > elemnt  = new List<int>();
        elemnt.Add(root.val);
        ret.Add(elemnt);
        int level = 0 ; 
          elemnt  = new List<int>();
        while (myqueue.Count >0 )
        {
            KeyValuePair< TreeNode, int> node  = myqueue.Dequeue() ; 
            if (level != node.Value )
            {
                if(level %2 == 0 )
                     elemnt=   elemnt.Reverse().ToList();
             if(elemnt.Count !=0)
                 ret.Add(elemnt);
            elemnt  = new List<int>();
            level=  node.Value ;
            } 
            TreeNode r  = node.Key.right ; 
            TreeNode l  = node.Key.left; 
               if(l!= null)
           {
                myqueue.Enqueue( new KeyValuePair<TreeNode, int>(l,node.Value+1)); 
                elemnt.Add(l.val);
           }
             if(r!= null)
           {
                myqueue.Enqueue(new KeyValuePair<TreeNode, int>(r,node.Value+1));
                elemnt.Add(r.val);
           }
        }
   
       return  ret  ;
        
        
    }
}