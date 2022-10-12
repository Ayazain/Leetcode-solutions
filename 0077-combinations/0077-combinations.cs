public class Solution {
 public  List<IList<int>> res = new List<IList<int>>() ; 
     public  void CombineHellper(int n, int k ,  int index  , List<int >Curr) 
     {
      if(Curr.Count == k ){
        res.Add(new List<int>(  Curr)); 
        return ; 
      }
      for  (int i = index ;  i <= n ;i++  )
      {
       Curr.Add(i); 
       CombineHellper(n , k  , i+1 , Curr   ); 
       Curr.RemoveAt(Curr.Count-1);
      }
      return  ; 
     }
     public IList<IList<int>> Combine(int n, int k) {
       CombineHellper(n , k  , 1, new List<int>()  );  
       
        return res  ; 
     }}