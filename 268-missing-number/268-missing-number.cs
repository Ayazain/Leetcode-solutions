public class Solution {
    public int MissingNumber(int[] nums) {
     int c = nums.Length * (nums.Length+1) ; 
        c/=2;
        for (int i = 0 ; i < nums.Length ; i++)
        {
            c-=nums[i]; 
        }
        return c  ; 
    }
}