/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
             
           public Node CloneGraph(Node node) 
           {
               
               if (node == null )
                  
                   return  node;
                
               if (node.neighbors == null )
                return  new Node(node.val );
                if (node.neighbors.Count == 0  )
                return  new Node(node.val );
               
              Node newnode = new Node(node.val );
            Queue<KeyValuePair<Node , Node>> MyQueue = new Queue<KeyValuePair<Node, Node>>();
            MyQueue.Enqueue(new KeyValuePair<Node, Node>(node , newnode)) ; 
            Dictionary<int ,  Node> visited  = new Dictionary<int, Node>() ;
            visited.Add(newnode.val, newnode) ; 
            while(MyQueue.Count>0 )
            {
                KeyValuePair<Node , Node> mynode  = MyQueue.Dequeue();
                foreach(Node x  in mynode.Key.neighbors)
                {
                   
                     if( visited.ContainsKey(x.val))
                     {
                          System.Console.Write("Here ") ; 
                        mynode.Value.neighbors.Add(visited[x.val]); 
                     }
                     else 
                     {
                           System.Console.Write("me me  ") ; 
                        Node newnigbour =  new Node(x.val);
                        visited.Add(newnigbour.val,newnigbour) ;
                           mynode.Value.neighbors.Add(visited[x.val]);
                        MyQueue.Enqueue(new KeyValuePair<Node, Node>(x , newnigbour)); 
                     }
                    
                }
               
            } 


               
        return newnode;
           }
}