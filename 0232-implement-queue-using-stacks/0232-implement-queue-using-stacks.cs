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
     ShiftStack(); 
     return oldest.Pop();
    }
    
    public void ShiftStack()
    {
  if ( oldest.Count <= 0 &&  newest.Count > 0 )
         { while( newest.Count > 0) oldest.Push(newest.Pop()); }  
    }

    public int Peek() {
         ShiftStack();
         return oldest.Peek() ;  
    }
    
    public bool Empty() {
        if (oldest.Count <= 0 && newest.Count <= 0) return true; 
        return false; 
    }
}