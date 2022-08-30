public class Solution {
 public int Count = 0;
    public int FindTargetSumWays(int[] nums, int target) {
       Dfs(0,0, target, nums);
       return Count;
    }
    public void Dfs(int i, int result, int target, int[] nums) {
        if(i == nums.Length) {
            if(result == target)
                Count++;
            return;
        }
        Dfs(i+1, result + nums[i], target, nums);
        Dfs(i+1, result - nums[i], target, nums);
    }

}