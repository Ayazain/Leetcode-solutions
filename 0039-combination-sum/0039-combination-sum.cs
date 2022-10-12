public class Solution {
 public  List<IList<int>> res = new List<IList<int>>() ; 
    
     public   void CombinationSumHellper (int[] candidates, int target , List<int >Curr , int CurrSum   ,int index ) {
      if (CurrSum >= target)
      {
       if  (CurrSum ==target) res.Add(new List<int>(Curr));
       return ; 
      }
      for (int i = index ; i < candidates.Length ; i++)
      { 
        
         if (CurrSum+candidates[i]  >target) continue ;
         CurrSum+=candidates[i] ;
         Curr.Add(candidates[i]);
        CombinationSumHellper(candidates , target ,Curr , CurrSum , i); 
          CurrSum-=candidates[i] ;
         Curr.RemoveAt(Curr.Count-1);
      }

      return ; 
     }
    
    
     public  IList<IList<int>> CombinationSum(int[] candidates, int target) {
      CombinationSumHellper(candidates , target , new List<int>() , 0, 0 );
     return res  ;    
    }
}