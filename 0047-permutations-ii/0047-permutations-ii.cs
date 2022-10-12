public class Solution {
   public  List<IList<int>> Ress = new List<IList<int>>() ; 
    public  bool ShouldSwap(int[]nums  , int Curr , int index  )
 {
  for (int i = Curr ; i < index ; i++)
  if (nums[i] ==  nums[index])return true ;
  return false ; 
 }
  public  void GrtPermutation(int []nums , int index  )
  {
    if (index  == nums.Length-1 )
    { Ress.Add(new List<int>(nums)); return; }  
    for (int i = index  ; i < nums.Length; i++)
    {
      if (ShouldSwap(nums , index , i))continue ; 
     //swap 
      int temp = nums[index]  ;
      nums[index] = nums[i] ; 
      nums[i] = temp ; 
      
      GrtPermutation(nums , index+1);
      
       temp = nums[index]  ;
      nums[index] = nums[i] ; 
      nums[i] = temp  ; 
    }
    return ; 
  }

 public  IList<IList<int>> PermuteUnique(int[] nums) {
        GrtPermutation(nums ,0);
        return Ress;
    }
}