  public class MyQueue {

    Stack<int > oldest ; 
    Stack<int > newest; 
    public MyQueue() {
        oldest = new Stack<int>(); 
        newest = new Stack<int>();
    }
    
    public void Push(int x) {
        newest.Push(x);
    }
    
    public int Pop() {
      int data ; 
        if (oldest.Count > 0 )
          data = oldest.Pop();
         
        else if ( newest.Count > 0 )
        { 
          while( newest.Count > 0) oldest.Push(newest.Pop());
          data =  oldest.Pop(); 
        }  
        else 
         data =  -1 ; 
         return data ;  
    }
    
    public int Peek() {
        int data ; 
        if (oldest.Count > 0 )
          data = oldest.Peek();
         
        else if ( newest.Count > 0 )
        { 
          while( newest.Count > 0) oldest.Push(newest.Pop());
          data =  oldest.Peek(); 
        }  
        else 
         data =  -1 ; 
         return data ;  
    }
    
    public bool Empty() {
        if (oldest.Count <= 0 && newest.Count <= 0) return true; 
        return false; 
    }
}
/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */