public class Solution {
 public  List<IList<int>> res = new List<IList<int>>() ; 
     public  void CombineHellper(int n, int k ,  int index  , List<int >Curr) 
     {
      if(Curr.Count == k ){
        res.Add(Curr); 
        return ; 
      }
      int i = index ; 
      while (Curr.Count< k && i <= n   )
      {
      List<int > temp = new List<int>( Curr); temp.Add(i); 
       CombineHellper(n , k  , i+1 , temp   ); 
       i++;
      }
      return  ; 
     }
     public   IList<IList<int>> Combine(int n, int k) {
       CombineHellper(n , k  , 1, new List<int>()  );  
       
        return res  ; 
     }
}