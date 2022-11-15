public class MinStack {
      
    Stack<int > myvalues ; 
    Stack<int > myMin ; 
    
    public MinStack() {
        myvalues = new Stack<int >() ; 
        myMin = new Stack<int>(); 
    }
    
    public void Push(int val) {
  
      if (myvalues.Count() == 0 ||GetMin() >=  val) 
         myMin.Push(val);  
         
      myvalues.Push(val); 
    }
    
   public void Pop() {
     
      if (GetMin() == myvalues.Pop() ) 
          myMin.Pop();
    }
    
    
    public int Top() {
         return myvalues.Peek(); 
    }
    
    public int GetMin() {    
       return  myMin.Peek();  
    }
}