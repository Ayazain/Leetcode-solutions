using System.Collections.Generic; 
public class Solution {
    public int MaxSubArray(int[] nums) {
         int sum=0; 
      int Max= int.MinValue; 
       if (nums.Length <= 1)
                return nums[0];
            else
            {
               
                for (int i = 0 ; i < nums.Length ;i++)
                {
                    sum+=nums[i];
                    Max = Math.Max(Max , sum); 
                    if(sum<0)
                    sum = 0 ;

                }


            }
            return Max;
    }
}