class StackElemnt 
    {
    int val ; int min  ; 
  public StackElemnt(int val , int min )
    {
      this.val  = val ; 
      this.min = min ; 
    }
    public int GetMin()
    {
      return min ; 
    }
    public int GetVal()
    {
      return val; 
    }
    }
   public class MinStack {
      
    Stack<StackElemnt> myvalues = new Stack<StackElemnt>() ; 
 
    public MinStack() {
        myvalues = new Stack<StackElemnt>() ; 
    }
    
    public void Push(int val) {  
        int minval = val ; 
      if (myvalues.Count() != 0 ) 
       minval = Math.Min (GetMin() , val); 
      StackElemnt  elemnt = new StackElemnt(val , minval) ; 
      myvalues.Push(elemnt); 
    }
    
    public void Pop() {
        myvalues.Pop(); 
    }
    
    public int Top() {
         StackElemnt elemnt  =  myvalues.Peek(); 
         return elemnt.GetVal(); 
    }
    
    public int GetMin() {
       StackElemnt minElemnt  =  myvalues.Peek(); 
       return minElemnt.GetMin(); 
    }
}