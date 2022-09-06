public class Solution {
    public int LengthOfLIS(int[] nums) {
         int []dp = new int [nums.Length];
    for (int i = nums.Length-2 ; i >=0 ; i--)
    {
        for (int j = i+1; j <= nums.Length-1 ; j++)
        {
            if(nums[i]<nums[j])
               dp[i]= Math.Max(dp[j]+1, dp[i]);  
        }
    }

    return dp.Max()+1;    
    }
}