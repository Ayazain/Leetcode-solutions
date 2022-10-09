public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int start = 0 ; int end = 0; int sum = 0  ; int count= int.MaxValue  ; 
        while  (end <= nums.Length)
        {
            if (sum >= target)
            {
               if (end-start <count)
                       count=end-start;
              sum-=nums[start] ;  start++; 
            }
            else if (end <nums.Length)
            {
             sum+=nums[end] ;  end++;
            }
            else
                break ; 
            
        }
       return (count==int.MaxValue)?0:count ; 
    }
}