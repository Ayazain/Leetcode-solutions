public class Solution {
     int max =0 ; 
    public int FindTargetSumWays(int[] nums, int target) 
    {
        DFS(  0 , 0 , target , nums );
        return max ; 
    }
     private void  DFS(int index , int sum , int target,int[] nums  )
    {
       if (index == nums.Length)
       {
           if (sum  == target )
               max++ ; 
           return  ; 
       }
          DFS(  index+1 ,  sum+nums[index] ,  target  , nums );
          DFS(  index+1 ,  sum-nums[index] ,  target , nums );
    }

}