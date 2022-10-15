public class Solution {
  public   bool CanJump(int[] nums)
    {
      int MaxnumOfJumbs  = 1 ; 
      for (int i = 0  ; i < nums.Length ; i++)
      {
        MaxnumOfJumbs = Math.Max(MaxnumOfJumbs-1 , nums[i]); 
        if (MaxnumOfJumbs == 0 &&  i != nums.Length-1 ) return false ;
      }
        return true ;
    }
}