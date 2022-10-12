public class Solution {
 public  List<IList<int>> res = new List<IList<int>>() ; 
  public  Dictionary<int  , bool > used  = new Dictionary<int, bool>();   
     public   void CombinationSumHellper (int[] candidates, int target , List<int >Curr , int CurrSum   ,int index ) {
      if (CurrSum >= target)
      {
       if  (CurrSum ==target) res.Add(new List<int>(Curr));
       return ; 
      }
      for (int i = index+1 ; i < candidates.Length ; i++)
      { 
       
        if (i >0 && candidates[i-1]==candidates[i]&& !used.ContainsKey(i-1))continue;
          if (CurrSum+candidates[i]  >target) continue ;
           used.Add(i , true  ) ; 
         CurrSum+=candidates[i] ;
         Curr.Add(candidates[i]);
        CombinationSumHellper(candidates , target ,Curr , CurrSum , i); 
        used.Remove(i);
          CurrSum-=candidates[i] ;
         Curr.RemoveAt(Curr.Count-1);
      }

      return ; 
     }
    
    
     public  IList<IList<int>> CombinationSum2(int[] candidates, int target) {
      Array.Sort(candidates ) ; 
      CombinationSumHellper(candidates , target , new List<int>() , 0, -1 );
     return res  ;    
    }
  
}