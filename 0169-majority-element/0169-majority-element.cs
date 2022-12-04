public class Solution {
    public int MajorityElement(int[] nums) {
        int majer = nums[0] ; 
        int count = 0 ; 
        for (int i = 0  ; i  < nums.Length ; i++)
        {
            if (count == 0 ) majer = nums[i];
            count += (majer == nums[i])?1:-1;
        }
        return majer;
    }
}