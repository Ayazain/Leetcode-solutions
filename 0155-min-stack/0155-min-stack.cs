public class MinStack {
      
    Stack<int > myvalues ; 
    Stack<int > myMin ; 
    
    public MinStack() {
        myvalues = new Stack<int >() ; 
        myMin = new Stack<int>(); 
    }
    
    public void Push(int val) {
  
      if (myvalues.Count() == 0 ||GetMin() >=  val) 
         {
         myMin.Push(val);  
         }
      myvalues.Push(val); 
    }
    
   public void Pop() {
      int removedVal =   myvalues.Pop(); 
      if (GetMin() == removedVal) 
      myMin.Pop();
    }
    
    
    public int Top() {
         return myvalues.Peek(); 
    }
    
    public int GetMin() {
    
       int  min  =  myMin.Peek(); 
       return min; 
    }
}