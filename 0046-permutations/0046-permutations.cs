public class Solution {
    public  List<IList<int>> Ress = new List<IList<int>>() ; 
  public  void GrtPermutation(List<int>CurrNums  , List<int>CurrRes )
  {
    if (CurrNums.Count == 1 )
    { CurrRes.AddRange(CurrNums); Ress.Add(CurrRes); return; }  
    for (int i = 0  ; i < CurrNums.Count ; i++)
    {
      List<int> k = new List<int>(CurrRes ); k.Add(CurrNums[i]) ;
      List<int>kk = new List<int>(CurrNums) ; kk.Remove(CurrNums[i]);
      GrtPermutation(kk , k);
    }
    return ; 
  }

 public  IList<IList<int>> Permute(int[] nums) {
        GrtPermutation(nums.ToList()  ,new  List<int>());
        return Ress;
    }
}