public class Solution {
  public   bool CanJump(int[] nums)
    {
        return CanJumpHelpper(nums, 0 , new Dictionary<int, bool>());
    }
    public   bool CanJumpHelpper(int[] nums, int index , Dictionary<int , bool > lookup)
    {
    
        if (index >= nums.Length-1) return true; 
        if (lookup.ContainsKey(index)) return lookup[index] ;
        bool res = false;
        for (int i = 1; i <= nums[index]; i++)
        {
            res|= CanJumpHelpper(nums , index+i , lookup);
            if (res ) return true ; 
        }
        lookup.Add(index , res)
;        return res ; 
    }
}