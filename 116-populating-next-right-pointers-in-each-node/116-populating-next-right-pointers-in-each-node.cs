/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
  public Node Connect(Node root) {
     
      if (root == null ) return root  ; 
        Queue< KeyValuePair< Node, int> > myQueue = new Queue< KeyValuePair <Node, int > >() ;
         myQueue.Enqueue(new KeyValuePair<Node, int>(root , 0 ));
         Node next  = null ;  bool Next  = false ; 
         Node Last = null ;  int level  = 0  ; 
      
         while(myQueue.Count > 0 )
         {
            
          KeyValuePair<Node, int >  myfullnode  = myQueue.Dequeue();
         
          Node mynode = myfullnode.Key ; 
             System.Console.WriteLine(mynode.val);
            if (level !=  myfullnode.Value)
            {
                Last.next = null ; 
                level = myfullnode.Value ; 
               
                Next = false;
            }
            if (mynode.left != null && mynode.right != null )
            {
            myQueue.Enqueue(new KeyValuePair<Node, int>( mynode.left , myfullnode.Value+1)) ; 
            myQueue.Enqueue(new KeyValuePair<Node, int>( mynode.right , myfullnode.Value+1)) ;  
           if (Next )
               next.next =  mynode.left ; 
            mynode.left.next = mynode.right ;
            next = mynode.right ;
                Next = true ;
            }
              
             Last = mynode ; 
             
         }
     
     
return root; 
    }
}